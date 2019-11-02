using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace VoiceInputSystem
{
    public partial class vcInputSystem : Form
    {
        //Initialize a new instance of the Speech Synthesizer
        SpeechSynthesizer txtToSpeech = new SpeechSynthesizer();

        //Initialize a new instance of the Speech Recognition
        SpeechRecognitionEngine spToText = new SpeechRecognitionEngine(
            new System.Globalization.CultureInfo("en-US"));

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);

        public vcInputSystem()
        {
            InitializeComponent();
        }

        private void vcInputSystem_Load(object sender, EventArgs e)
        {
            txtToSpeech.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Child);
            output.Text = "Welcome To Voice Input System";
            Choices ch = new Choices();
            ch.Add(new string[] {"Hello","Excel","Close","Word","Powerpoint","Notepad","Wordpad","Paint","Command","Calculator","Date","Time","Google","View","Hide" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(ch);
            Grammar grammar = new Grammar(gb);
            spToText.LoadGrammarAsync(grammar);
            spToText.SetInputToDefaultAudioDevice();
            spToText.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sE_SpeechRecognized);
        }

        void sE_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //configure the audio output
            txtToSpeech.SetOutputToDefaultAudioDevice();

            if (e.Result.Text == "Hello")
            {
                //Change the content of Text
                msg.Text = "Hello, I am Voice Input System! Developed By Gyanendra Pandey. Version V.1";

                //Speak a String
                txtToSpeech.Speak("Hello, I am Voice Input System! Developed By Gyanendra Pandey. Version V.1");
            }

            else if (e.Result.Text == "Close")
            {
                //Change the content of Text
                msg.Text = "Closing Application";

                //Speak a String
                txtToSpeech.Speak("Closing Application");

                //Command to Exit the Application
                Application.Exit();
            }

            else if(e.Result.Text == "Excel")
            {
                //Change the content of Text
                msg.Text = "Opening Micro Soft Excel";

                //Speak a String
                txtToSpeech.Speak("Opening Micro Soft Excel");

                //run the excel
                run_excel();
            }
            else if (e.Result.Text == "Word")
            {
                //Change the content of Text
                msg.Text = "Opening Micro Soft Word";

                //Speak a String
                txtToSpeech.Speak("Opening Micro Soft Word");

                //run the excel
                run_word();
            }

            else if (e.Result.Text == "Powerpoint")
            {
                //Change the content of Text
                msg.Text = "Opening Micro Soft Powerpoint";

                //Speak a String
                txtToSpeech.Speak("Opening Micro Soft Powerpoint");

                //run the excel
                run_powerpnt();
            }

            else if (e.Result.Text == "Notepad")
            {
                //Change the content of Text
                msg.Text = "Opening Windows Notepad";

                //Speak a String
                txtToSpeech.Speak("Opening Windows Notepad");

                //run the excel
                run_notepad();
            }

            else if (e.Result.Text == "Wordpad")
            {
                //Change the content of Text
                msg.Text = "Opening Windows Wordpad";

                //Speak a String
                txtToSpeech.Speak("Opening Windows Wordpad");

                //run the excel
                run_wordpad();
            }

            else if (e.Result.Text == "Paint")
            {
                //Change the content of Text
                msg.Text = "Opening Windows Paint";

                //Speak a String
                txtToSpeech.Speak("Opening Windows Paint");

                //run the excel
                run_paint();
            }

            else if (e.Result.Text == "Command")
            {
                //Change the content of Text
                msg.Text = "Opening Windows Command Prompt";

                //Speak a String
                txtToSpeech.Speak("Opening Windows Command Prompt");

                //run the excel
                run_command();
            }

            else if (e.Result.Text == "Calculator")
            {
                //Change the content of Text
                msg.Text = "Opening Windows Calculator";

                //Speak a String
                txtToSpeech.Speak("Opening Windows Calculator");

                //run the excel
                run_calculator();
            }

            else if(e.Result.Text == "Date")
            {
                output.Text = "Today Date is: " + DateTime.Now.ToString("yyyy-MM-dd");
                txtToSpeech.Speak("Today Date is: " + DateTime.Now.ToString("yyyy-MM-dd"));
            }

            else if (e.Result.Text == "Time")
            {
                time.Text = "Current Time is: " + DateTime.Now.ToString("hh:mm:ss");
                txtToSpeech.Speak("Current Time is: " + DateTime.Now.ToString("hh:mm:ss"));
            }

            else if (e.Result.Text == "View")
            {
                //Change the content of Message Text
                msg.Text = "Displaying All Commands";
                txtToSpeech.Speak("Displaying All Commands");
                listCmd.Visible = true;
                hideAllCmd.Enabled = true;
            }

            else if (e.Result.Text == "Hide")
            {
                //Change the content of Message Text
                msg.Text = "Hiding All Commands";
                txtToSpeech.Speak("Hiding All Commands");
                listCmd.Visible = false;
                hideAllCmd.Enabled = false;
            }

            else if (e.Result.Text == "Google")
            {
                //Change the content of Text
                output.Text = "Opening Google Chrome";

                //Speak a String
                txtToSpeech.Speak("Opening Google Chrome");

                //run the excel
                run_chrome();
            }
            
        }

        private void enbleBtn_Click(object sender, EventArgs e)
        {
            spToText.RecognizeAsync(RecognizeMode.Multiple);
            dsbleBtn.Enabled = true;
            viewCmd.Enabled = false;
            enbleBtn.Enabled = false;

            //configure the audio output
            txtToSpeech.SetOutputToDefaultAudioDevice();

            msg.Text = "Enabling Voice Input System";
            //Speak a String
            txtToSpeech.Speak("Enabling Voice Input System");

            output.Text = "Welcome To Voice Input System";
            //Speak a String
            txtToSpeech.Speak("Welcome To Voice Input System");
            

            output.Text = "Today Date is: " + DateTime.Now.ToString("yyyy-MM-dd");
            //Speak a String
            txtToSpeech.Speak("Today Date is: " + DateTime.Now.ToString("yyyy-MM-dd"));
            
            
            time.Text = "Current Time is: " + DateTime.Now.ToString("hh:mm:ss");
            //Speak a String
            txtToSpeech.Speak("Current Time is: " + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void dsbleBtn_Click(object sender, EventArgs e)
        {
            //configure the audio output
            txtToSpeech.SetOutputToDefaultAudioDevice();

            msg.Text = "Disable Voice Recognition";
            //Speak a String
            txtToSpeech.Speak("Disable Voice Recognition");

            spToText.RecognizeAsyncStop();
            dsbleBtn.Enabled = false;
            enbleBtn.Enabled = true;
            viewCmd.Enabled = true;
        }

        //1. View All Command List
        private void viewCmd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listing All Command");
            listCmd.Visible = true;
            viewCmd.Enabled = false;
            hideAllCmd.Enabled = true;
        }

        //2. Function To Run Microsoft Excel
        public void run_excel()
        {
            try
            { 
                Process p = Process.Start("excel.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception MS Excel: "+e);
            }
        }

        //3. Function To Run Microsoft Word
        public void run_word()
        {
            try
            {
                Process p = Process.Start("winword.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception MS Word: " + e);
            }
        }

        //4. Function To Run Windows Calculator
        public void run_calculator()
        {
            try
            {
                Process p = Process.Start("calc.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Calculator: " + e);
            }
        }

        //5. Function To Windows Paint
        public void run_paint()
        {
            try
            {
                Process p = Process.Start("mspaint.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception Windows Paint: " + e);
            }
        }

        //6. Function To Run Command Prompt
        public void run_command()
        {
            try { 
            Process p = Process.Start("cmd.exe");
            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, this.Handle);
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception Command Prompt: " + e);
            }
        }

        //7. Function To Run Google
        public void run_chrome()
        {
            try
            {
                Process p = Process.Start("chrome.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception Google: "+e);
            }
        }
        
        //8. Function To Run Windows Notepad
        public void run_notepad()
        {
            try
            {
                Process p = Process.Start("notepad.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Notepad:" + e);
            }
        }

        //9. Function To Run Microsoft Power Point
        public void run_powerpnt()
        {
            try
            {
                Process p = Process.Start("powerpnt.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception MS Powerpoint: " + e);
            }
        }

        //10. Function To Hide All Command
        private void hideAllCmd_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Hiding All Command");
                listCmd.Visible = false;
                viewCmd.Enabled = true;
                hideAllCmd.Enabled = false;
            }
            catch (Exception f)
            {
                MessageBox.Show("Exception Hide Button: " + f);
            }
        }

        //11. Function To Run Windows Notepad
        public void run_wordpad()
        {
            try
            {
                Process p = Process.Start("wordpad.exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Wordpad: " + e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
