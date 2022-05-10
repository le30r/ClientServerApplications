using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_EF
{
    public partial class Form : System.Windows.Forms.Form
    {
        LanguagesEDM context = new LanguagesEDM();
        string newLine = Environment.NewLine;
        public Form()
        {
            InitializeComponent();
        }

        private void staticQueryBtn_Click(object sender, EventArgs e)
        {
            var french = context.Languages.Where(x => x.Name == "французский").ToList();
            
            foreach (var lang in french)
            {
                staticResultTextBox.Text = "ID: " + lang.ID.ToString().Trim() + newLine + "Название: " + lang.Name.Trim() + newLine +
                    "Языковая группа: " + lang.LanguageGroup.Trim() + newLine +  "Знаковая система: " + lang.SignSystem.Trim();
            }
        }

        private void ethnicalButton_Click(object sender, EventArgs e)
        {
            ethnicalResultTextBox.Clear();
            foreach (var ethnical in SelectEthnical(countryTextBox.Text, languageTextBox.Text))
            {
                ethnicalResultTextBox.AppendText(ethnical.Country + " " +  ethnical.Language + 
                    " " +  ethnical.PopulationCount + " " + ethnical.Year + newLine);
            }
        }

        private List<Ethnical> SelectEthnical(string country, string language)
        {
            var ethnical = context.Ethnical.Where(x => x.Country == context.Countries.Where(c => c.Name == country).FirstOrDefault().ID)
                                                .Where(x => x.Language == context.Languages.Where(l => l.Name == language).FirstOrDefault().ID).ToList();
            return ethnical;
        }

        private void langButton_Click(object sender, EventArgs e)
        {
            languagesResultTextBox.Clear();
            foreach (var lang in SelectLanguages(langNameTextBox.Text))
            {
                languagesResultTextBox.AppendText("ID: " + lang.ID.ToString().Trim() + newLine + "Название: " + lang.Name.Trim() + newLine +
                    "Языковая группа: " + lang.LanguageGroup.Trim() + newLine + "Знаковая система: " + lang.SignSystem.Trim());
            }
        }

        private List<Languages> SelectLanguages(string name)
        {
            var languages = context.Languages.Where(x => x.Name == name).ToList();

            return languages;
        }
    }
}
