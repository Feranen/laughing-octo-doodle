// Plansza 10x10
// Losowo przesuwamy 2 duszki (-2, 2)

using Sprite.Models;

var bones = new Sprite.Models.Sprite("Szkielet",2,2);
var oscar = new Sprite.Models.Sprite("Oskar", 8, 8);

var rnd = new Random();
var iter = 0;
do
{
    var dx = rnd.Next(-2,3);
    var dy = rnd.Next(-2,3);
    bones.Move(dx,dy);
    dx = rnd.Next(-2, 3);
    dy = rnd.Next(-2, 3);
    oscar.Move(dx,dy);


    Console.WriteLine($"{iter++}-------------");
    bones.ShowPosition();
    oscar.ShowPosition();
    
    

} while (!bones.IsAt(oscar.x, oscar.y) && iter < 20);
Console.WriteLine("Koniec");