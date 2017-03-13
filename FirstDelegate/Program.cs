using System.Collections.Generic;
using System.Linq;

namespace FirstDelegate
{
    class Program
    {

        public delegate Person DoSomeWork ( List<Person> Persone , string par );


        static void Main ( string[] args )
        {
            List<Person> Persone = PersonDB();

        }


        private static List<Person> PersonDB ()
        {
            List<Person> lista = new List<Person>()
            {
                new Person() {Nome = "Sebastiano", Cognome = "Gaudeano"},
                new Person() {Nome = "Cristina", Cognome = "Paoloni"},
                new Person() {Nome = "Alberto", Cognome = "Cristicchi"},
                new Person() {Nome = "Susanna", Cognome = "TuttaPanna"},
                new Person() {Nome = "Guido", Cognome = "LaVespa"}
            };

            return lista;
        }

        private Person FilterPersonByName ( List<Person> Persone , string nome )
        {
            Person persona = new Person();

            return persona = Persone.FirstOrDefault( nome => );
        }
    }
}
