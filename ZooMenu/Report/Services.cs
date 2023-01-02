using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMenu.Report
{
    internal class Services
    {
        public static void DocForAnimal(double countFirst, double countSecond, double countThird, 
            string nameOfAnimal, string nameOfFirstFeed, string nameOfSecondFeed, string nameOfThirdFeed)
        {
            int i = 0;
            Random x = new Random();
            int n = x.Next(0, 1000000000);
            string factSeason = "";

            var helper = new WordHelper("D:\\Projects\\ZooMenu\\ZooMenu\\Report\\animalPerMonth.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "MenuFromStasik" },
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<ANIMAL>", nameOfAnimal.ToString()},
                {"<NAMEFIRST>", nameOfFirstFeed},
                {"<NAMESECOND>", nameOfSecondFeed},
                {"<NAMETHIRD>", nameOfThirdFeed},
                {"<COUNTFIRST>", Math.Round(countFirst, 2).ToString()+" кг"},
                {"<COUNTSECOND>", Math.Round(countSecond, 2).ToString()+" кг"},
                {"<COUNTTHIRD>", Math.Round(countThird, 2).ToString()+" кг"},
                {"<FACTSEASON>", factSeason},
            };
            MessageBox.Show("Документ успішно сформовано!");
            helper.CreatingDoc(items);
        }
        public static void DocForSeason(double autumn, double winter, double spring, double summer)
        {
            int i = 0;
            Random x = new Random();
            int n = x.Next(0, 1000000000);
            double[] arr = new double[]
            {
                autumn,
                winter, spring, summer
            };
            string factSeason = "";
            foreach (double d in arr)
            {
                if (d == arr.Max())
                {
                    break;
                }
                i++;
            }
            if (i == 0)
            {
                factSeason = "осінь";
            }
            if (i == 1)
            {
                factSeason = "зима";
            }
            if (i == 2)
            {
                factSeason = "весна";
            }
            if (i == 3)
            {
                factSeason = "літо";
            }
            var helper = new WordHelper("D:\\Projects\\ZooMenu\\ZooMenu\\Report\\seasons.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "MenuFromStasik" },
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<AUTUMN>", autumn +" кг"},
                {"<WINTER>", winter +" кг"},
                {"<SPRING>", spring +" кг" },
                {"<SUMMER>", summer +" кг"},
                {"<FACT>", arr.Max().ToString()+" кг"},
                {"<FACTSEASON>", factSeason},
            };
            MessageBox.Show("Документ успішно сформовано!");
            helper.CreatingDoc(items);
        }
    }
}
