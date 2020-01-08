using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class GameForm : Form
    {
        string text1 = "Księżyc to jedyne ciało niebieskie, do którego podróżowali i " +
            "na którym wylądowali ludzie. Do tej pory na księżycowym globie stanęło 12 osób. Pierwszym " +
            "sztucznym obiektem w historii, który przeleciał blisko Księżyca, była wystrzelona przez Związek " +
            "Radziecki sonda kosmiczna Łuna 1; Łuna 2 jako pierwszy statek osiągnęła powierzchnię ziemskiego " +
            "satelity, zaś Łuna 3 jeszcze w tym samym roku, co poprzedniczki - 1959 - wykonała pierwsze zdjęcia " +
            "niewidocznej z Ziemi strony Księżyca.";

        string text2 = "Betelgeza jest czerwonym nadolbrzymem o typie widmowym M1-2. Jej rozmiar kątowy został " +
            "zmierzony po raz pierwszy w 1921 roku, ale zależy on od długości fali i pulsacji gwiazdy, a dodatkowo " +
            "niepewność wyznaczenia odległości utrudnia określenie rzeczywistej średnicy gwiazdy. Oceny z 2016 " +
            "roku wskazują, że ma ona promień 887 +- 203 razy większy od słonecznego, czyli około 3-5 au. Gdyby znajdowała " +
            "się na miejscu Słońca, wypełniałaby Układ Słoneczny do orbity Jowisza. Jasność tej gwiazdy, przy założeniu " +
            "odległości około 640 lat świetlnych, 105 tysięcy razy przewyższa jasność Słońca.";

        string text3 = "Enceladus jest księżycem lodowym, zbudowanym w znacznym stopniu z lodu. Jego powierzchnia jest " +
            "stosunkowo młoda, bogata w twory takie jak kratery, gładkie równiny oraz rozległe szczeliny i grzbiety. " +
            "Przypuszcza się, że ukształtowała się około 100 milionów lat temu wskutek wydobywania się wody z wnętrza księżyca. " +
            "Pokrywający ją świeży, czysty lód sprawia, że Enceladus ma największe albedo ze wszystkich obiektów w Układzie " +
            "Słonecznym - odbija ponad 90% padającego nań światła. Niewielka ilość pochłanianej energii słonecznej powoduje, " +
            "że temperatura powierzchni wynosi w południe zaledwie -198 stopni C. Mimo to na tym niewielkim księżycu obserwujemy szczeliny, " +
            "z których wyrzucane są strumienie pary i pyłu, podobnie do ziemskich gejzerów.";

        string text4 = "W mitologii greckiej Orion był myśliwym. Posejdon (jego ojciec) obdarzył go umiejętnością chodzenia po wodzie. " +
            "Zakochany był w Plejadach, które nieustannie goni na niebie. Chełpił się, że może zabić każde stworzenie, a zginął ukąszony " +
            "przez skorpiona i od tej pory znajdują się na przeciwnych stronach nieboskłonu. Zachodzi w chwili, gdy jego zabójca, "+
            "reprezentowany przez gwiazdozbiór Skorpiona, ukazuje się nad horyzontem. Jego pies - Syriusz - jest najjaśniejszą "+
            "gwiazdą nocnego nieba i stanowi część konstelacji Wielkiego Psa.";

        string text5 = "Do niedawna sądzono, że Galaktyka Andromedy jest najmasywniejszą galaktyką w Grupie Lokalnej, " +
            "w skład której wchodzą również Droga Mleczna, Galaktyka Trójkąta oraz około 50 mniejszych galaktyk. Obecnie, na " +
            "podstawie nowszych danych obserwacyjnych, uważa się, że Droga Mleczna zawiera więcej ciemnej materii i może być " +
            "najmasywniejszym obiektem w grupie. Galaktyka Andromedy ma jednak znacznie więcej gwiazd, obserwacje przy pomocy " +
            "Teleskopu Spitzera pozwalają szacować ich liczbę na około bilion.";

        string textToWrite = string.Empty;

        TypeRacer typeRacer;

        public GameForm(Level level, ChooseRaceLevel previousMenu)
        {
            InitializeComponent();

            switch (level)
            {
                case Level.first:
                    textToWrite = text1;
                    break;
                case Level.second:
                    textToWrite = text2;
                    break;
                case Level.third:
                    textToWrite = text3;
                    break;
                case Level.fourth:
                    textToWrite = text4;
                    break;
                case Level.fifth:
                    textToWrite = text5;
                    break;
            }

            typeRacer = new TypeRacer(textToWrite,
                this,
                previousMenu,
                txtActualWordToWrite,
                txtPassedTime,
                txtUserWordInput,
                txtWholeTextToBeWritten,
                txtWordsPerMinute,
                level);

            typeRacer.StartRace();
        }

        private void txtUserWordInput_TextChanged(object sender, EventArgs e)
        {
            typeRacer.txtUserWordInput_TextChangedFunc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm t = new LoginForm();

            this.Hide();
            t.Show();
        }
    }
}
