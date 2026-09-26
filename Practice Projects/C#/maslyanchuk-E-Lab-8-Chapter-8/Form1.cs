using System.Diagnostics.Tracing;
using System.Text;

namespace maslyanchuk_E_Chapter_8_Lab_8
{
    //Eric Maslyanchuk
    //Lab 8
    //Chapter 8
    //CPT-185-A01

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //check to see if the text box is empty 
                if (stringTextBox.Text == null)
                {
                    //message says to enter something
                    MessageBox.Show("Please enter a sentence or number.");
                    return;
                }
                else
                {
                    //varibles
                    string userInput;

                    //create a string builder 
                    StringBuilder morseCode = new StringBuilder();

                    //create variable of what user enterd (trimming input here)
                    userInput = stringTextBox.Text.Trim().ToUpper();

                    //loop true the array of strings
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        //change userInput element to a character 
                        char letter = userInput[i];

                        //convert the word to morse code
                        switch (letter)
                        {
                            case 'A':
                                morseCode.Append(".- ");
                                break;

                            case 'B':
                                morseCode.Append("-... ");
                                break;

                            case 'C':
                                morseCode.Append("-.-. ");
                                break;

                            case 'D':
                                morseCode.Append("-.. ");
                                break;

                            case 'E':
                                morseCode.Append(". ");
                                break;

                            case 'F':
                                morseCode.Append("..-. ");
                                break;

                            case 'G':
                                morseCode.Append("--. ");
                                break;

                            case 'H':
                                morseCode.Append(".... ");
                                break;

                            case 'I':
                                morseCode.Append(".. ");
                                break;

                            case 'J':
                                morseCode.Append(".--- ");
                                break;

                            case 'K':
                                morseCode.Append("-.- ");
                                break;
                            case 'L':
                                morseCode.Append(".-.. ");
                                break;

                            case 'M':
                                morseCode.Append("-- ");
                                break;

                            case 'N':
                                morseCode.Append("-. ");
                                break;

                            case 'O':
                                morseCode.Append("--- ");
                                break;

                            case 'P':
                                morseCode.Append(".--. ");
                                break;

                            case 'Q':
                                morseCode.Append("--.- ");
                                break;

                            case 'R':
                                morseCode.Append(".-. ");
                                break;

                            case 'S':
                                morseCode.Append("... ");
                                break;

                            case 'T':
                                morseCode.Append("- ");
                                break;

                            case 'U':
                                morseCode.Append("..- ");
                                break;

                            case 'V':
                                morseCode.Append("...- ");
                                break;

                            case 'W':
                                morseCode.Append(".-- ");
                                break;

                            case 'X':
                                morseCode.Append("-..- ");
                                break;

                            case 'Y':
                                morseCode.Append("-.-- ");
                                break;

                            case 'Z':
                                morseCode.Append("--.. ");
                                break;

                            case '0':
                                morseCode.Append("----- ");
                                break;

                            case '1':
                                morseCode.Append(".---- ");
                                break;

                            case '2':
                                morseCode.Append("..--- ");
                                break;

                            case '3':
                                morseCode.Append("...-- ");
                                break;

                            case '4':
                                morseCode.Append("....- ");
                                break;

                            case '5':
                                morseCode.Append("..... ");
                                break;

                            case '6':
                                morseCode.Append("-.... ");
                                break;

                            case '7':
                                morseCode.Append("--... ");
                                break;

                            case '8':
                                morseCode.Append("---.. ");
                                break;

                            case '9':
                                morseCode.Append("----. ");
                                break;

                            case ' ':
                                morseCode.Append("/ ");
                                break;

                            case '?':
                                morseCode.Append("..--.. ");
                                break;

                            default:
                                morseCode.Append("UNKNOWN ");
                                break;

                        }
                    }

                    //show the full Morse code result
                    resultsLabel.Text = morseCode.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears the text box and the label
            stringTextBox.Text = string.Empty;
            resultsLabel.Text = string.Empty;

            //focus on process button
            stringTextBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //closes the form with message
            MessageBox.Show("Thank You for using Morse Code Converter");
            this.Close();
        }
    }
}
