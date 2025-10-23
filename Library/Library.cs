using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Library
    {
        private List<Literature> Funds { get; set; } = [];

        public Library()
        {
            Funds.Add(new Book()
            {
                Author = "D. Knuth",
                Title = "The art of programming",
                Publisher = "Київ, Наукова Думка",
                Year = 2000
            });
            Funds.Add(new Book()
            {
                Author = "J. Richter",
                Title = "CLR via C#",
                Publisher = "Microsoft Press",
                Year = 2013
            });
            Funds.Add(new Journal()
            {
                Title = "ArgC & ArgV",
                Number = "2(113), 2000",
                Publisher = "https://journals.ua/technology/argc-argv/"
            });
            Funds.Add(new Newspaper()
            {
                Title = "Gazette de Leopol",
                Publisher = "First Ukrainian press in Ukraine",
                Date = new DateOnly(1776, 1, 15)
            });
            Funds.Add(new Booklet()
            {
                Title = "Безпечний інтернет для дітей",
                Publisher = "ГО «Центр цифрової грамотності»",
                Year = 2024,
                Organization = "Міністерство освіти і науки України"
            });
        }

        public void PrintCatalog()
        {
            foreach (Literature literature in Funds)
            {
                Console.WriteLine(literature.GetCard());
            }
        }
    }
}
