using ModLoader.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModLoader.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Class1 test = new Class1();

            //HtmlOutput.Text = await test.parseSynthira();

            SynthiraRu soup = new SynthiraRu("https://synthira.ru/load/drugie_igry/the_sims_4/");
            await soup.ParseData(); // обязательный метод
                                    //HtmlOutput.Text = soup.Descriptions.Text();

            HtmlOutput.Text = await soup.GetData();
            //HtmlOutput.Text = soup.Names.Html();
            //HtmlOutput.Text = soup.Document;
            //HtmlOutput.Text = string.Join(",", soup.Names);
            //foreach (var item in soup.Names)
            //{
            //   HtmlOutput.Text = item.InnerHtml;
            //}

            // await Method();

            //HtmlOutput.Text = await MethodWithResult();

            //TestAsync test = new TestAsync();
            //HtmlOutput.Text = await test.MethodWithResult();
            //Class1 test = new Class1();
            //await HtmlOutput.Text = test.text;
            //var config = Configuration.Default.WithDefaultLoader();
            //var address = "https://synthira.ru/";
            //var context = BrowsingContext.New(config);
            //var document = await context.OpenAsync(address);
            //var cells = document.QuerySelectorAll(".filekmod .mvis"); // сразу отсев идет по цепочке CSS-СЕЛЕКТОРЫ
            //HtmlOutput.Text = cells[0].InnerHtml;

            //var test = new SynthiraRu(address);

            //HtmlOutput.Text = test.Name;

            // HtmlOutput.Text = this.getHtml();
        }

        // public string getHtml()
        // {
        // var soup = new BeautifulSoup("https://synthira.ru/load/drugie_igry/the_sims_4/");
        //var text = soup.FindAll(class_:"filekmod");
        //return text.ToString();
        //}


    }
}
