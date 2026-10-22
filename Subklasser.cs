using System;

namespace Oosu_LAB1
{
    // 1. KursBok
    public class KursBok : Annons
    {
        private string isbn;
        private string författare;
        private string upplaga;

        public KursBok(int id, string titel, decimal pris, string beskrivning, string status, Kurs kurs, string isbn, string författare, string upplaga)
            : base(id, titel, pris, beskrivning, status, kurs)
        {
            this.isbn = isbn;
            this.författare = författare;
            this.upplaga = upplaga;
        }

        public override string GetInfo()
        {
            return $"Kursbok: {författare}, Upplaga: {upplaga} (ISBN: {isbn})";
        }
    }

    // 2. Kompendium
    public class Kompendium : Annons
    {
        private int antalSidor;
        private int utgivningsår;

        public Kompendium(int id, string titel, decimal pris, string beskrivning, string status, Kurs kurs, int antalSidor, int utgivningsår)
            : base(id, titel, pris, beskrivning, status, kurs)
        {
            this.antalSidor = antalSidor;
            this.utgivningsår = utgivningsår;
        }

        public override string GetInfo()
        {
            return $"Kompendium: {antalSidor} sidor, utgivet {utgivningsår}";
        }
    }

    // 3. DigitalResurs
    public class DigitalResurs : Annons
    {
        private string filformat;
        private string leveranssätt;

        public DigitalResurs(int id, string titel, decimal pris, string beskrivning, string status, Kurs kurs, string filformat, string leveranssätt)
            : base(id, titel, pris, beskrivning, status, kurs)
        {
            this.filformat = filformat;
            this.leveranssätt = leveranssätt;
        }

        public override string GetInfo()
        {
            return $"Digital resurs ({filformat}), levereras via: {leveranssätt}";
        }
    }
}
