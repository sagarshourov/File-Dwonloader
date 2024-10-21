using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DownloaderForm
{
    public partial class VideoDwonloader : Form
    {
        private HttpClient _client = new HttpClient();
        public VideoDwonloader()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textUrl.Text))
            {
                MessageBox.Show("Base Url is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textUrl.Focus(); // Set focus to the first missing field
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFrom.Text))
            {
                MessageBox.Show("From is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFrom.Focus(); // Set focus to the second missing field
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTo.Text))
            {
                MessageBox.Show("To is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTo.Focus(); // Set focus to the second missing field
                return;
            }

            if (string.IsNullOrWhiteSpace(lblDestination.Text))
            {
                MessageBox.Show("Destination is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSetDestination.Focus(); // Set focus to the second missing field
                return;
            }



            if (textUrl != null && textBoxFrom != null && textBoxTo != null && lblDestination !=null)
            {
                // Get the text from the TextBox that triggered the event

              

               var  url = textUrl.Text; // URL from the textbox
                int start = int.Parse( textBoxFrom.Text);
                int end = int.Parse(textBoxTo.Text);
                var destination = lblDestination.Text;

             //   var destination = @"C:\Downloads\files3.mp4";


                for (int i = start; i <= end; i++)
                {
                    // Update path as necessary
                    destination += @"\"+i+".mp4";

                    lblDwonloadingFile.Text = destination;

                    url += "/" + i + ".mp4";
                    try
                    {
                        using (var response = await _client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                        {
                            response.EnsureSuccessStatusCode();

                            var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                            using (var contentStream = await response.Content.ReadAsStreamAsync())
                            {
                                await SaveFileAsync(contentStream, destination, totalBytes);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show($"Error: {ex.Message}");

                        Logger.Log($"Error: {ex.Message}");
                    }
                    destination = lblDestination.Text;
                    url = textUrl.Text;
                }


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = sender as TextBox;

            //if (textBox != null)
            //{
            //    // Get the text from the TextBox that triggered the event
            //    string currentText = textBox.Text;
            //    Console.WriteLine($"Text changed in {textBox.Name}: {currentText}");

            
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
          
        }


        private async Task SaveFileAsync(Stream contentStream, string filePath, long totalBytes)
        {
            var buffer = new byte[8192];
            var totalReadBytes = 0L;
            var isMoreToRead = true;

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, buffer.Length, true))
            {
                do
                {
                    var readBytes = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        isMoreToRead = false;
                        continue;
                    }

                    await fileStream.WriteAsync(buffer, 0, readBytes);
                    totalReadBytes += readBytes;

                    // Update the progress bar
                    if (totalBytes != -1)
                    {
                        var progress = (int)((totalReadBytes * 1d) / totalBytes * 100);
                        progressBar.Value = progress;
                    }
                }
                while (isMoreToRead);
            }

           // MessageBox.Show("Download completed!");

            Logger.Log(filePath+" = Download completed!");
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSetDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Please select a folder";
                folderBrowser.ShowNewFolderButton = true;


                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected folder path in the textBox1
                    lblDestination.Text = folderBrowser.SelectedPath;
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenDestination_Click(object sender, EventArgs e)
        {
            string folderPath = lblDestination.Text; // Or set the folder path manually

            if (!string.IsNullOrWhiteSpace(folderPath) && System.IO.Directory.Exists(folderPath))
            {
                // Open the folder in Windows Explorer
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Please select a valid folder.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VideoDwonloader_Load(object sender, EventArgs e)
        {

        }
    }

    //55478

    public class Logger
    {
        private static string logFilePath = @"C:\Logs\Video Dwonloader log.txt"; // Change to the desired log file path

        // Method to log a message to the log file
        public static void Log(string message)
        {
            try
            {
                // Ensure that the directory exists, and create it if it doesn't
                string logDirectory = Path.GetDirectoryName(logFilePath);
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory); // Create the directory if it doesn't exist
                }

                // Check if the file exists, create it if it does not, and append the message
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}"); // Write the log message with a timestamp
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while trying to log
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }



}
