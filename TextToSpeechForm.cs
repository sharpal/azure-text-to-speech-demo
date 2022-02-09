using System;
using System.IO;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Windows.Forms;

namespace Text_to_Speech_Demo
{
    public partial class TextToSpeechForm : Form
    {
        public TextToSpeechForm()
        {
            InitializeComponent();
        }

        private async void buttonTTS_Click(object sender, EventArgs e)
        {
            this.EnableControls(false);
            this.textBoxStatus.Clear();

            if (string.IsNullOrWhiteSpace(this.textboxInputFile.Text) || 
                string.IsNullOrWhiteSpace(this.textBoxOutputFile.Text) ||
                !File.Exists(this.textboxInputFile.Text) ||
                !Directory.Exists(this.textBoxOutputFile.Text))
            {
                this.textBoxStatus.AppendText("Input text file or output path are not properly set.");
                this.EnableControls(true);

                return;
            }

            try
            {
                this.textBoxStatus.AppendText("Processing...");

                var config = SpeechConfig.FromSubscription("<<your search api subscription key goes here>>", "<<your search api location goes>>");
                
                config.SpeechSynthesisLanguage = "te-IN";
                config.SpeechSynthesisVoiceName = ((Voice)this.comboBoxVoice.SelectedItem).SpeechSynthesisVoiceName;
                
                var outputFile = Path.Combine(this.textBoxOutputFile.Text, this.textboxInputFile.Text + "." + DateTime.Now.ToString("yyyy-MM-dd hh.mm.ss") + ".wav");
                var content = File.ReadAllText(this.textboxInputFile.Text);

                using var audioConfig = AudioConfig.FromWavFileOutput(outputFile);
                using var synthesizer = new SpeechSynthesizer(config, audioConfig);
                
                var result = await synthesizer.SpeakTextAsync(content);
                this.textBoxStatus.AppendText(Environment.NewLine + result.Reason.ToString());
            }
            catch(Exception ex)
            {
                this.textBoxStatus.AppendText(Environment.NewLine + "Error:");
                this.textBoxStatus.AppendText(ex.Message);
                this.textBoxStatus.AppendText(ex.StackTrace);
            }

            this.EnableControls(true);
        }

        private void EnableControls(bool flag)
        {
            this.textboxInputFile.Enabled = flag;
            this.textBoxOutputFile.Enabled = flag;
            this.buttonBrowseInputFile.Enabled = flag;
            this.buttonOutputFile.Enabled = flag;
            this.buttonTTS.Enabled = flag;
            this.comboBoxVoice.Enabled = flag;
        }
        private void buttonBrowseInputFile_Click(object sender, EventArgs e)
        {
            var dialogResult = this.openInputFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.textboxInputFile.Text = this.openInputFileDialog.FileName;
            }
        }

        private void buttonOutputFile_Click(object sender, EventArgs e)
        {
            var result = this.folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxOutputFile.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void TextToSpeechForm_Load(object sender, EventArgs e)
        {
            this.comboBoxVoice.Items.Add(new Voice() { VoiceName = "Mohan", SpeechSynthesisVoiceName = "te-IN-MohanNeural" });
            this.comboBoxVoice.Items.Add(new Voice() { VoiceName = "Shruti", SpeechSynthesisVoiceName = "te-IN-ShrutiNeural" });
            this.comboBoxVoice.DisplayMember = "VoiceName";
            this.comboBoxVoice.ValueMember = "SpeechSynthesisVoiceName";
            this.comboBoxVoice.SelectedIndex = 0;
        }
    }

    internal class Voice
    {
        public string VoiceName { get; set; }
        public string SpeechSynthesisVoiceName { get; set; }
    }
}
