using System;
using System.Drawing;
using System.Windows.Forms;

namespace JapanDictionary
{
    public partial class MainForm : Form
    {
        WebBrowser wb = new WebBrowser();
        public MainForm()
        {
            // initializing design/gui components 
            InitializeComponent();
            word_panel.Visible = false;
            WordTextbox.Visible = false;
            TipLabel.Visible = false;
            loading_status.Enabled = true;
            loading_status.Visible = true;

            // creating WebBrowser and navigating it to the dictionary website
            wb = new WebBrowser();
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate("http://www.jardic.ru/search/");
            wb.DocumentCompleted += Wb_DocumentCompleted;
            // give the GUI command to display the current status
            loading_status.Text = "Секунду, подключаюсь к серверам..";
        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // we show everything as soon as the dictionary webiste is loaded programmatically
            loading_status.Visible = false;
            loading_status.Enabled = false;
            word_panel.Visible = true;
            WordTextbox.Visible = true;
            TipLabel.Visible = true;
        }

        private void WordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wb.Navigate("http://www.jardic.ru/search/search_r.php?q=" + WordTextbox.Text);
                wb.DocumentCompleted += Wb_DocumentCompleted1;
            }
        }

        private void Wb_DocumentCompleted1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // the given word is not in the dictionary, display it to the user
            if (wb.Document.Body.OuterText.Contains("По этому запросу ничего не найдено"))
            {
                MessageBox.Show("По этому запросу ничего не найдено в словарях, возможно вы опечатались.\nПопробуйте ввести другие слова.");
            }
            else if (wb.Document.Body.OuterText.Contains("Найдено статей") || wb.Document.Body.OuterText.Contains("Jardic"))
            {
                // we found a word in the dictionary and display data about it
                word_panel.Controls.Clear();
                var content_tab = wb.Document.GetElementById("tabContent");
                var content_body = content_tab.GetElementsByTagName("tbody");
                var content_tr = content_body[0].GetElementsByTagName("tr");
                for (int i = 0; i < content_tr.Count; i++)
                {
                    var tr_td = content_tr[i].GetElementsByTagName("td");
                    var td_span = tr_td[0].GetElementsByTagName("span");
                    string japan_text = "";
                    string alternative_text = "";
                    string value_text = "";
                    for (int i1 = 0; i1 < td_span.Count; i1++)
                    {
                        if (i1 == 0)
                            japan_text = td_span[i1].OuterText;
                        if (td_span.Count > 2 && i1 == 1)
                            alternative_text = td_span[i1].OuterText;
                        if (i1 == (td_span.Count - 1))
                            value_text = td_span[i1].OuterText;
                    }
                    word word = new word();
                    word.front_japan.Text = japan_text;
                    word.front_alternative.Text = alternative_text;
                    word.front_content.Text = value_text;
                    word.Size = new Size(298, 132);
                    word.Location = new Point(0, 0);
                    if (!String.IsNullOrEmpty(japan_text))
                        word_panel.Controls.Add(word);
                }
            }
        }

        private void WordTextbox_Click(object sender, EventArgs e)
        {
            // we remove the text immediately when clicked, so that the user does not have to erase it himself
            if (WordTextbox.Text == "Введите слово")
                WordTextbox.Text = "";
        }
    }
}
