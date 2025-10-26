using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Funds.Add(new Hologram()
            {
                Title = "Скіфське мистецтво",
                ArtItem = "Пектораль",
                Publisher = "Студія 'Лазер'"

            });
            Funds.Add(new Poster()
            {
                Title = "Неонова Ніч",
                Publisher = "Mistral Films & Black Forest Productions",
                Date = new DateOnly(2025, 11, 1)
            });
        }

        public void PrintCatalog()
        {
            foreach (Literature literature in Funds)
            {
                Console.WriteLine(literature.GetCard());
            }
        }

        public void PrintPeriodic()
        {
            foreach (Literature literature in Funds)
            {
                if (literature is IPeriodic lit)
                {
                    Console.WriteLine($"Раз у {lit.GetPeriod()}: ");
                    Console.WriteLine(literature.GetCard());
                }
            }
        }

        public void PrintNonPeriodic()
        {
            foreach (Literature literature in Funds)
            {
                if (literature is not IPeriodic)
                {
                    Console.WriteLine(literature.GetCard());
                }
            }
        }

        public void PrintPrintable()
        {
            foreach (Literature literature in Funds)
            {
                if (literature is not INonPrintable)
                {
                    Console.WriteLine(literature.GetCard());
                }
            }
        }

        public void PrintNonPrintable()
        {
            foreach (Literature literature in Funds)
            {
                if (literature is INonPrintable)
                {
                    Console.WriteLine(literature.GetCard());
                }
            }
        }
    }
}
