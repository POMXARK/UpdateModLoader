
using ModLoader.UI.Data.Repositories;
using MVVM;
using System.Linq;
using System.Windows;

namespace ModLoader.UI.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// https://www.codeproject.com/Articles/819294/WPF-MVVM-step-by-step-Basics-to-Advance-Level
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            //DataContext = new SimsApplicationViewModel();

            ////var test = new List<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };
            //var test = GamesRepository.GetAll().Select(u => u.Name).ToList()[0];
            //tabHeader.Text = test;
            //var mods = ModRepository.GetAll().Select(u => u.Name).ToList();
            //testList.ItemsSource = mods;
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Class1 test = new Class1();

            //HtmlOutput.Text = await test.parseSynthira();


            //SynthiraRuRepository soup = new SynthiraRuRepository("https://synthira.ru/load/drugie_igry/the_sims_4/");
           /* await soup.ParseData();*/ // обязательный метод
            //HtmlOutput.Text = soup.Descriptions.Text();

            //HtmlOutput.Text = await soup.GetData();

            ///

            //Extensions.RunDownload("wcCoR1194F7t388", "Симлинк / Simzlink 1.3 (04.09.2022)", 20);

            //await soup.DownloadAsync();
            //var myProcess = new Process();
            //myProcess.StartInfo.FileName = "cmd.exe";
            //myProcess.Start();

            //  .\main.exe https://modsfire.com/d/wcCoR1194F7t388 C:\Users\User\Downloads\TEST\new 10



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

        private void Button_Click_Test(object sender, RoutedEventArgs e)
        {
            //var allFiles = Extensions.GetAllFiles("C:\\Users\\User\\Downloads\\TEST\\downloads_new\\SynthiraRu", "*.*");
            //HtmlOutput.Text = string.Join("\n", allFiles);
            //Extensions.Unpack(allFiles);
            Extensions.CreateSymbolicLinkForPack("C:\\Users\\User\\Documents\\Electronic Arts\\The Sims 4\\Packs\\Mods");
        }

        private void Button_Click_All(object sender, RoutedEventArgs e)
        {
           /* TestHtmlOutput.Text = GamesRepository.GetAll().ToArray()[0].Name;*///.DumpAsYaml();
        }



        // public string getHtml()
        // {
        // var soup = new BeautifulSoup("https://synthira.ru/load/drugie_igry/the_sims_4/");
        //var text = soup.FindAll(class_:"filekmod");
        //return text.ToString();
        //}


    }
}
