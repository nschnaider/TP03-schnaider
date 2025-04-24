namespace TP03_schnaider.Models;

public static class Empresa{
    public static Dictionary<string, Disco> discos{get; private set;}

public static void inicializarDisco()
{
    discos = new Dictionary<string, Disco>();

    // Disco 1
    List<string> temas1 = new List<string>();
    temas1.Add("Wanna Be Startin' Somethin'");
    temas1.Add("Thriller");
    temas1.Add("Beat It");
    temas1.Add("Billie Jean");

    Disco disco1 = new Disco("Thriller", "Michael Jackson", temas1, "Pop", "Quincy Jones", "1", "thriller.jpg");
    discos.Add(disco1.id, disco1);

    // Disco 2
    List<string> temas2 = new List<string>();
    temas2.Add("Come Together");
    temas2.Add("Something");
    temas2.Add("Here Comes the Sun");

    Disco disco2 = new Disco("Abbey Road", "The Beatles", temas2, "Rock", "George Martin", "2", "abbeyroad.jpg");
    discos.Add(disco2.id, disco2);

    // Disco 3
    List<string> temas3 = new List<string>();
    temas3.Add("Smells Like Teen Spirit");
    temas3.Add("Come As You Are");
    temas3.Add("Lithium");

    Disco disco3 = new Disco("Nevermind", "Nirvana", temas3, "Grunge", "Butch Vig", "3", "nevermind.jpg");
    discos.Add(disco3.id, disco3);

    // Disco 4
    List<string> temas4 = new List<string>();
    temas4.Add("Hells Bells");
    temas4.Add("Shoot to Thrill");
    temas4.Add("Back in Black");

    Disco disco4 = new Disco("Back in Black", "AC/DC", temas4, "Hard Rock", "Robert John Lange", "4", "backinblack.jpg");
    discos.Add(disco4.id, disco4);

    // Disco 5
    List<string> temas5 = new List<string>();
    temas5.Add("Like a Prayer");
    temas5.Add("Express Yourself");
    temas5.Add("Cherish");

    Disco disco5 = new Disco("Like a Prayer", "Madonna", temas5, "Pop", "Patrick Leonard", "5", "likeaprayer.jpg");
    discos.Add(disco5.id, disco5);

    // Disco 6
    List<string> temas6 = new List<string>();
    temas6.Add("Lose Yourself");
    temas6.Add("8 Mile");
    temas6.Add("Till I Collapse");

    Disco disco6 = new Disco("The Eminem Show", "Eminem", temas6, "Hip Hop", "Dr. Dre", "6", "eminemshow.jpg");
    discos.Add(disco6.id, disco6);

    // Disco 7
    List<string> temas7 = new List<string>();
    temas7.Add("Blank Space");
    temas7.Add("Style");
    temas7.Add("Shake It Off");

    Disco disco7 = new Disco("1989", "Taylor Swift", temas7, "Pop", "Max Martin", "7", "1989.jpg");
    discos.Add(disco7.id, disco7);

    // Disco 8
    List<string> temas8 = new List<string>();
    temas8.Add("Bad Guy");
    temas8.Add("When the Party's Over");
    temas8.Add("Bury a Friend");

    Disco disco8 = new Disco("When We All Fall Asleep, Where Do We Go?", "Billie Eilish", temas8, "Alternative", "Finneas OConnell", "8", "billie.jpg");
    discos.Add(disco8.id, disco8);
}

}
