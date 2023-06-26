using System.Security.Cryptography;
using System.Text;

namespace Secure_Password_Generator
{
    public partial class Password_Generator : Form
    {
        public Password_Generator()
        {
            InitializeComponent();
        }
        private static int RndInt()
        {
            byte[] buffer = new byte[sizeof(int)];
            RandomNumberGenerator.Create().GetBytes(buffer);
            return BitConverter.ToInt32(buffer, 0);
        }

        private static int BoundedInt(int min, int max)
        {
            int value = RndInt();
            int range = max - min;
            return min + (Math.Abs(value) % range);
        }

        private void GeneratePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordRadioBtn.Checked)
                {
                    decimal len = passLenNumeric.Value;

                    string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string lowerCase = upperCase.ToLower();
                    string specialChars = "!@#$%^&*()_-+={[}];:'\"<,>.?/\\";
                    string numericChars = "1234567890";

                    bool upper = passCapitalLetters.Checked;
                    bool lower = passLowerCase.Checked;
                    bool special = passSpecialChars.Checked;
                    bool numeric = passNumericChars.Checked;

                    if (!(upper || lower || special || numeric))
                        throw new DivideByZeroException();

                    string allowedChars = string.Empty;

                    if (upper) allowedChars += upperCase;
                    if (lower) allowedChars += lowerCase;
                    if (special) allowedChars += specialChars;
                    if (numeric) allowedChars += numericChars;

                    StringBuilder stringBuilder = new StringBuilder();
                    string result = string.Empty;
                    for (int i = 0; i < len; i++)
                    {
                        int index = BoundedInt(0, allowedChars.Length);
                        stringBuilder.Append(allowedChars[index]);

                        result = stringBuilder.ToString();
                    }

                    outputText.Text = result;
                }
                else if (passPhraseRadioBtn.Checked)
                {
                    decimal len = wordAmountCounter.Value;

                    Dictionary<int, string> indexedDictionary = new Dictionary<int, string>();

                    string file = "WordList.txt";
                    string[] lines = File.ReadAllLines(file);

                    for (int i = 0; i < lines.Length; i++)
                        indexedDictionary.Add(i, lines[i]);

                    string delimiter = delimiterBox.SelectedIndex switch
                    {
                        0 => " ",
                        1 => "-",
                        2 => "/",
                        3 => ".",
                        _ => throw new ArgumentException("Invalid delimiter index.")
                    };

                    if (delimiterBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a delimiter from the drop-down box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] words = new string[(int)len];
                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = 0; i < wordAmountCounter.Value; i++)
                    {
                        stringBuilder.Clear();
                        words[i] = indexedDictionary[BoundedInt(0, indexedDictionary.Count)];
                        stringBuilder.Append(words[i]);
                        words[i] = stringBuilder.ToString();
                    }

                    string joined = string.Join(delimiter, words);
                    outputText.Text = joined;

                    if (capitalLetters.Checked)
                    {
                        for (int i = 0; i < wordAmountCounter.Value; i++)
                        {
                            stringBuilder.Clear();
                            words[i] = indexedDictionary[BoundedInt(0, indexedDictionary.Count)];
                            string letter = words[i].Substring(0, 1);
                            string word = words[i].Substring(1);
                            string result = letter.ToUpper() + word;
                            stringBuilder.Append(result);
                            words[i] = stringBuilder.ToString();
                        }

                        joined = string.Join(delimiter, words);
                        outputText.Text = joined;
                    }

                    if (includeNumbers.Checked)
                    {
                        int num = BoundedInt(0, 10);

                        if (words.Length <= 0)
                        {
                            for (int i = 0; i < wordAmountCounter.Value; i++)
                            {
                                stringBuilder.Clear();
                                words[i] = indexedDictionary[BoundedInt(0, indexedDictionary.Count)];
                                string letter = words[i].Substring(0, 1);
                                string word = words[i].Substring(1);
                                string result = letter.ToUpper() + word;
                                stringBuilder.Append(result);
                                words[i] = stringBuilder.ToString();
                            }
                        }

                        string numStr = Convert.ToString(num);
                        joined = string.Join(delimiter, words) + "-" + numStr;
                        outputText.Text = joined;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a password type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}