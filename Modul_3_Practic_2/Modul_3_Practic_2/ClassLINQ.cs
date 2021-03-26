using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul_3_Practic_2
{
    public class ClassLINQ
    {
        private List<Contact> _strArray = new List<Contact>()
            {
                new Contact { FirstName = "Abc", LastName = "abc", PhoneNumber = "9379992" },
                new Contact { FirstName = "Abcd", LastName = "Abc", PhoneNumber = "1111111" },
                new Contact { FirstName = "ABcde", LastName = "ABC", PhoneNumber = "2222222" },
                new Contact { FirstName = "ABCdef", LastName = "bca", PhoneNumber = "3333333" },
                new Contact { FirstName = "ABCDefg", LastName = "Bca", PhoneNumber = "4444444" },
                new Contact { FirstName = "ABCDefgh", LastName = "BCA", PhoneNumber = "5555555" },
                new Contact { FirstName = "ABCDEfghi", LastName = "cba", PhoneNumber = "6666666" },
                new Contact { FirstName = "ABCDEfghij", LastName = "Cba", PhoneNumber = "7777777" },
                new Contact { FirstName = "ABCDEFghijk", LastName = "CBA", PhoneNumber = "8888888" },
                new Contact { FirstName = "ABCDEFGhijkl", LastName = "aaa", PhoneNumber = "9999999" },
                new Contact { FirstName = "ABCDEFGHijklm", LastName = "bbb", PhoneNumber = "0000000" }
            };
        public void Contacts()
        {
            Console.WriteLine("\t -All_ListContact-");
            foreach (Contact s in _strArray)
            {
                Console.WriteLine($"{s.FullName} {s.PhoneNumber}");
            }

            Console.WriteLine("\t -Block_Where-");
            var whereContact = _strArray.Where(w => w.FullName.StartsWith('A')).OrderByDescending(o => o.FullName);
            foreach (Contact s in whereContact)
            {
                Console.WriteLine($"{s.FullName} {s.PhoneNumber}");
            }

            Console.WriteLine("\t -Block_FirstOfDefault-");
            var firstOrDefaultContact = _strArray.FirstOrDefault(w => w.FirstName.Contains('D'));
            Console.WriteLine(firstOrDefaultContact == null ? "No such contact exist" : firstOrDefaultContact.FullName + firstOrDefaultContact.PhoneNumber);

            Console.WriteLine("\t -Block_Select-");
            var selectContact = _strArray.Select(p => new { p, p.FirstName });
            foreach (var s in selectContact)
            {
                Console.WriteLine(s.FirstName);
            }

            Console.WriteLine("\t -Block_ElementAtOrDefault");
            var elementAtOrDefaultContact = _strArray.ElementAtOrDefault(3);
            Console.WriteLine(elementAtOrDefaultContact.FullName + elementAtOrDefaultContact.PhoneNumber);

            Console.WriteLine("\t -Block_SkipWhile-");     // работает по дурному
            var skipWhileContact = _strArray.SkipWhile(w => w.FirstName.Contains('b'));
            foreach (var s in skipWhileContact)
            {
                Console.WriteLine(s.FullName + s.PhoneNumber);
            }
        }
    }
}