using System.Collections.Generic;
using System.Linq;
using Examen_FinalCalidad.Controllers;
using Examen_FinalCalidad.Models;
using Examen_FinalCalidad.Repository;
using Moq;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void JuanGanaPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
        
        
        [Test]
        public void OscarYMariaGanaPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void JuanPabloJoelPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void OscarManuelGanaPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void KathiaJoelYMAnuelGanaPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void Emplates5GanaPartidaDePoker()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void Solo1Ganador()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void GanadorCon1323123()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 1323123;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(1323123, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(1323123);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void JUarGanaCOn13Puntos()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 13;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(13, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(13);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
         
        [Test]
        public void GanadorConROyal50000puntos()
        {

            List<string> a = new List<string>();
            var userMock = new Mock<IUserRepository>();


            var baraja = new List<Card>();



            var cartaMock = new Mock<ICardRepository>();
            cartaMock.Setup(o => o.RepartirCartas()).Returns(baraja);
            cartaMock.Setup(o => o.Score(baraja)).Returns(3000);
            List<Usser> jugadores = new List<Usser>();
            jugadores.Add(new Usser(1, "Juan", 1323123));
            jugadores.Add(new Usser(2, "Jorge", 1323123));
            jugadores.Add(new Usser(3, "Luis", 1323123));
            jugadores.Add(new Usser(4, "Jose", 1323123));
            jugadores.Add(new Usser(5, "a", 1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Score(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usser> ganador = new List<Usser>();
            Usser nuevo = new Usser();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Score = 500000;
            abc.Add(Nombre1);
            abc.Add(Nombre2);
            abc.Add(Nombre3);
            abc.Add(Nombre4);
            abc.Add(Nombre5);
            userMock.Setup(o => o.Ganador(500000, jugadores)).Returns(ganador);
            userMock.Setup(o => o.Puntajes(baraja, jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Apostadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.MaxScore(jugadores)).Returns(500000);


            CardController jugegoPoker = new CardController(cartaMock.Object, userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);

            ganador.Add(nuevo);

            var ResultadoEsperado = ganador;
            Assert.AreEqual(ResultadoEsperado, ganadores);
        }
    }
}
      
