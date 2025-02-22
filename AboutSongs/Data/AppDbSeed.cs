using AboutSongs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AboutSongs.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Albuns
        List<Album> albuns = new()
        {
            new Album() {
                Id = 1,
                Titulo = "We Don't Trust You",
                Foto = "/img/Albuns/1.png",
                DataDeLancamento = DateTime.Parse ("22/03/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 2,
                Titulo = "HIT ME HARD AND SOFT",
                Foto = "/img/Albuns/2.jpg",
                DataDeLancamento = DateTime.Parse ("17/05/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 3,
                Titulo = "Short n'Sweet",
                Foto = "/img/Albuns/3.png",
                DataDeLancamento = DateTime.Parse ("23/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 4,
                Titulo = "American Dream",
                Foto = "/img/Albuns/4.jpg",
                DataDeLancamento = DateTime.Parse ("12/01/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 5,
                Titulo = "Utopia",
                Foto = "/img/Albuns/5.jpg",
                DataDeLancamento = DateTime.Parse ("28/07/2023"),
            },
            new Album() {
                Id = 6,
                Titulo = "333",
                Foto = "/img/Albuns/6.jpg",
                DataDeLancamento = DateTime.Parse ("09/09/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 7,
                Titulo = "Vagabundo de Luxo",
                Foto = "/img/Albuns/7.png",
                DataDeLancamento = DateTime.Parse ("10/07/2024"),
            },
            new Album() {
                Id = 8,
                Titulo = "Brat",
                Foto = "/img/Albuns/8.jpg",
                DataDeLancamento = DateTime.Parse ("07/06/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 9,
                Titulo = "Not Like Us",
                Foto = "/img/Albuns/9.png",
                DataDeLancamento = DateTime.Parse ("04/05/2024"),
            },
            new Album() {
                Id = 10,
                Titulo = "Die With A Smile",
                Foto = "/img/Albuns/10.jpeg",
                DataDeLancamento = DateTime.Parse ("16/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 11,
                Titulo = "WOKE UP",
                Foto = "/img/Albuns/11.png",
                DataDeLancamento = DateTime.Parse ("21/05/2024"),
            },
            new Album() {
                Id = 12,
                Titulo = "Family Matters",
                Foto = "/img/Albuns/12.png",
                DataDeLancamento = DateTime.Parse ("03/05/2024"),
            },
            new Album() {
                Id = 13,
                Titulo = "MTG QUERO VER SE VOCÊ TEM ATITUDE",
                Foto = "/img/Albuns/13.png",
                DataDeLancamento = DateTime.Parse ("02/07/2024"),
            },
            new Album() {
                Id = 14,
                Titulo = "Euphoria",
                Foto = "/img/Albuns/14.png",
                DataDeLancamento = DateTime.Parse ("30/04/2024"),
            },
            new Album() {
                Id = 15,
                Titulo = "Timeless (with Playboi Carti)",
                Foto = "/img/Albuns/15.jpg",
                DataDeLancamento = DateTime.Parse ("27/09/2024"),
            },
            new Album() {
                Id = 16,
                Titulo = "MILLION DOLLAR BABY",
                Foto = "/img/Albuns/16.png",
                DataDeLancamento = DateTime.Parse ("26/04/2024"),
            },
            new Album() {
                Id = 17,
                Titulo = "Feelslikeimfallinginlove",
                Foto = "/img/Albuns/17.png",
                DataDeLancamento = DateTime.Parse ("21/06/2024"),
            },
            new Album() {
                Id = 18,
                Titulo = "Eternal Sunshine",
                Foto = "/img/Albuns/18.png",
                DataDeLancamento = DateTime.Parse ("08/03/2024"),
            },
            new Album() {
                Id = 19,
                Titulo = "Vultures 1",
                Foto = "/img/Albuns/19.png",
                DataDeLancamento = DateTime.Parse ("09/02/2024"),
            },
            new Album() {
                Id = 20,
                Titulo = "THE BOX MEDLEY FUNK 2",
                Foto = "/img/Albuns/20.png",
                DataDeLancamento = DateTime.Parse ("18/04/2024"),
            },
            new Album() {
                Id = 21,
                Titulo = "2093",
                Foto = "/img/Albuns/21.png",
                DataDeLancamento = DateTime.Parse ("16/02/2024"),
            },
            new Album() {
                Id = 22,
                Titulo = "Chromakopia",
                Foto = "/img/Albuns/22.png",
                DataDeLancamento = DateTime.Parse ("28/10/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 23,
                Titulo = "Barbie",
                Foto = "/img/Albuns/23.png",
                DataDeLancamento = DateTime.Parse ("18/10/2024"),
            },
            new Album() {
                Id = 24,
                Titulo = "APT.",
                Foto = "/img/Albuns/24.png",
                DataDeLancamento = DateTime.Parse ("18/10/2024"),
            },
            new Album() {
                Id = 25,
                Titulo = "Nada Como um Dia Após o Outro Dia, Vol. 1 & 2",
                Foto = "/img/Albuns/25.png",
                DataDeLancamento = DateTime.Parse ("07/10/2007"),
            },
            new Album() {
                Id = 26,
                Titulo = "The Emptiness Machine",
                Foto = "/img/Albuns/26.png",
                DataDeLancamento = DateTime.Parse ("05/11/2024"),
            },

        };
        builder.Entity<Album>().HasData(albuns);
        #endregion

        #region Populate Musica 
        List<Musica> musicas = new(){
            new Musica() {
                Id = 1,
                Título = "We Don’t Trust You ",
                Compositores = "Barrett Strong, Christopher Townsend, Dwayne Richardson, Leland Wayne, Mejdi Rhars, Nayvadius Wilburn, Norman Whitfield e Paul Fishman",
                Duracao = TimeSpan.Parse ("3:46"),
                Spotify = "https://open.spotify.com/intl-pt/album/2vHRMDYWkdjZLRsLD4l76m",
                AppleMusic = "https://music.apple.com/br/album/we-dont-trust-you/1737149923",
                Youtube = "https://music.youtube.com/watch?v=ntP8vvswhYM&si=M-b2L6_XjMRkJfxm"
            },
            new Musica() {
                Id = 2,
                Título = "Young Metro",
                Compositores = "Abel Tesfaye, Eren Yüksel, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:25"),
        Spotify = "https://open.spotify.com/intl-pt/track/2pt55UXA7ycI7zlTqWoUWp",
                AppleMusic = "https://music.apple.com/br/song/ice-attack/1737150153",
                Youtube = "https://music.youtube.com/watch?v=ntP8vvswhYM&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 3,
                Título = "Ice Attack",
                Compositores = "Darnell Carlton, Jordan Houston, Leland Wayne, Nayvadius Wilburn, Nik Frascona, Paul Beauregard e Ricky Dunigan",
                Duracao = TimeSpan.Parse ("3:19"),
        Spotify = "https://open.spotify.com/intl-pt/track/0ftg9eDVh0t4qEBhdbPld8",
                AppleMusic = "https://music.apple.com/br/song/ice-attack/1737150153",
                Youtube = "https://music.youtube.com/watch?v=ycRKgIDciG4&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 4,
                Título = "Type Shit",
                Compositores = "Joe Cooley,Kendrick Lamar Duckworth, Kobe Hood, Leland Wayne, Nayvadius Wilburn e Rodney Oliver",
                Duracao = TimeSpan.Parse ("3:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/15dWsK6pH4OAEKD2aUt1aY",
                AppleMusic = "https://music.apple.com/br/song/type-shit/1737150156",
                Youtube = "https://music.youtube.com/watch?v=I0fgkcTbBoI&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 5,
                Título = "Claustrophobic",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:42"),
        Spotify = "https://open.spotify.com/intl-pt/track/2dEnQVj4DqzvaUgWOy33UW",
                AppleMusic = "https://music.apple.com/br/song/claustrophobic/1737150164",
                Youtube = "https://music.youtube.com/watch?v=LP2WmJCaUfU&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 6,
                Título = "Like That",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:27"),
        Spotify = "https://open.spotify.com/intl-pt/track/5M2KX4eOJLWlPdjV1UPwzS",
                AppleMusic = "https://open.spotify.com/intl-pt/track/5M2KX4eOJLWlPdjV1UPwzS",
                Youtube = "https://music.youtube.com/watch?v=N9bKBAA22Go&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 7,
                Título = "Slimed In",
                Compositores = "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen",
                Duracao = TimeSpan.Parse ("3:14"),
        Spotify = "https://open.spotify.com/intl-pt/track/66lptTO1aTEYHzamQKupjG",
                AppleMusic = "https://music.apple.com/br/song/slimed-in/1737150442",
                Youtube = "https://music.youtube.com/watch?v=ZJ0d2c3FOow&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 8,
                Título = "Magic Don Juan (Princess Diana)",
                Compositores = "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen",
                Duracao = TimeSpan.Parse ("3:40"),
        Spotify = "https://open.spotify.com/intl-pt/track/6mT6KW30jV7sz9TFW2G5S1",
                AppleMusic = "https://music.apple.com/br/song/magic-don-juan-princess-diana/1737150443",
                Youtube = "https://music.youtube.com/watch?v=MfTFbkKHPGI&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 9,
                Título = "Cinderella",
                Compositores = "Allen Ritter, Andre Proctor, Ethan Stevens, Jacques Webster, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:49"),
        Spotify = "https://open.spotify.com/intl-pt/track/4xAuVetRNiHvfZYppbTLPF",
                AppleMusic = "https://music.apple.com/br/song/cinderella/1737150446",
                Youtube = "https://music.youtube.com/watch?v=onP2eoO7byc&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 10,
                Título = "Runnin Outta Time",
                Compositores = "Bobby Raps, Leland Wayne, Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:25"),
        Spotify = "https://open.spotify.com/intl-pt/track/67i0lzzfTYrhxthfxBqYq6",
                AppleMusic = "https://music.apple.com/br/song/runnin-outta-time/1737150450",
                Youtube = "https://music.youtube.com/watch?v=Vv5UuKSBhZg&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 11,
                Título = "Fried (She a Vibe)",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:30"),
        Spotify = "https://open.spotify.com/intl-pt/track/6ucsW32idjJuE6OIUeqsNB",
                AppleMusic = "https://music.apple.com/br/song/fried-she-a-vibe/1737150451",
                Youtube = "https://music.youtube.com/watch?v=0Z8eMHVwFDw&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 12,
                Título = "Ain’t No Love",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/6FV9QPuQIhLFCC0EF2hn3c",
                AppleMusic = "https://music.apple.com/br/song/everyday-hustle/1737150458",
                Youtube = "https://music.youtube.com/watch?v=Dat993XlIf0&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 13,
                Título = "Everyday Hustle",
                Compositores = "Alfreda Brockington, Leland Wayne, Nayvadius Wilburn e William Leonard Roberts II",
                Duracao = TimeSpan.Parse ("3:46"),
        Spotify = "https://open.spotify.com/intl-pt/track/4eRqmUWBmEdnVEEDHu765H",
                AppleMusic = "https://music.apple.com/br/song/everyday-hustle/1737150458",
                Youtube = "https://music.youtube.com/watch?v=cdxE4QtUz-8&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 14,
                Título = "GTA",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:53"),
        Spotify = "https://open.spotify.com/intl-pt/track/7e3fAVgYa6rLAWVZtcXYlN",
                AppleMusic = "https://music.apple.com/br/song/gta/1737150460",
                Youtube = "https://music.youtube.com/watch?v=A8bE-MPs0K0&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 15,
                Título = "Seen it All",
                Compositores = "Allen Ritter, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:59"),
        Spotify = "https://open.spotify.com/intl-pt/track/7e3fAVgYa6rLAWVZtcXYlN",
                AppleMusic = "https://music.apple.com/br/song/seen-it-all/1737150465",
                Youtube = "https://music.youtube.com/watch?v=NZJGKmGhbwY&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 16,
                Título = "WTFYM",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("4:52"),
        Spotify = "https://open.spotify.com/intl-pt/track/5NJjhW5AtfaMM14pbqAOtn",
                AppleMusic = "https://music.apple.com/br/album/we-dont-trust-you/1737149923",
                Youtube = "https://music.youtube.com/watch?v=bDgZEPAaXyw&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 17,
                Título = "Where My Twin @ - Bonus",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/5Hu9qHhcDlDbXG7EiGYZhR",
                AppleMusic = "https://music.apple.com/br/song/where-my-twin-bonus-track/1737150980",
                Youtube = "https://music.youtube.com/watch?v=jiMDe3U6_5M&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8"
            },
            new Musica() {
                Id = 18,
                Título = "SKINNY",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("3:39"),
        Spotify = "https://open.spotify.com/intl-pt/track/1CsMKhwEmNnmvHUuO5nryA",
                AppleMusic = "https://music.apple.com/br/song/skinny/1739659137",
                Youtube = "https://music.youtube.com/watch?v=GcY-5alayP8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
            },
            new Musica() {
            Id = 19,
            Título = "LUNCH",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("2:59"),
            Spotify = "https://open.spotify.com/intl-pt/track/629DixmZGHc7ILtEntuiWE",
            AppleMusic = "https://music.apple.com/br/song/lunch/1739659140",
            Youtube = "https://music.youtube.com/watch?v=MB3VkzPdgLA&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
        },
        new Musica() {
            Id = 20,
            Título = "CHIHIRO",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("5:03"),
            Spotify = "https://open.spotify.com/intl-pt/track/7BRD7x5pt8Lqa1eGYC4dzj",
            AppleMusic = "https://music.apple.com/br/song/chihiro/1739659141",
            Youtube = "https://music.youtube.com/watch?v=BY_XwvKogC8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
            },
        new Musica() {
            Id = 21,
            Título = "BIRDS OF A FEATHER",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("3:30"),
            Spotify = "https://open.spotify.com/intl-pt/track/6dOtVTDdiauQNBQEDOtlAB",
            AppleMusic = "https://music.apple.com/br/song/birds-of-a-feather/1739659142",
            Youtube = "https://music.youtube.com/watch?v=BY_XwvKogC8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
        },
        new Musica() {
            Id = 22,
            Título = "WILDFLOWER",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("4:21"),
            Spotify = "https://open.spotify.com/intl-pt/track/3QaPy1KgI7nu9FJEQUgn6h",
            AppleMusic = "https://music.apple.com/br/song/wildflower/1739659144",
            Youtube = "https://music.youtube.com/watch?v=IWKyykQBRKo&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
            },
        new Musica() {
            Id = 23,
            Título = "THE GREATEST",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("4:53"),
            Spotify = "https://open.spotify.com/intl-pt/track/6TGd66r0nlPaYm3KIoI7ET",
            AppleMusic = "https://music.apple.com/br/song/the-greatest/1739659145",
            Youtube = "https://music.youtube.com/watch?v=xozgvccBHk8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
        },
        new Musica() {
            Id = 24,
            Título = "L’AMOUR DE MA VIE",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("5:33"),
            Spotify = "https://open.spotify.com/intl-pt/track/6fPan2saHdFaIHuTSatORv",
            AppleMusic = "https://music.apple.com/br/song/lamour-de-ma-vie/1739659149",
            Youtube = "https://music.youtube.com/watch?v=lWzjDk5sJRc&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
        },
        new Musica() {
            Id = 25,
            Título = "THE DINER",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("3:06"),
            Spotify = "https://open.spotify.com/intl-pt/track/1LLUoftvmTjVNBHZoQyveF",
            AppleMusic = "https://music.apple.com/br/song/the-diner/1739659150",
            Youtube = "https://music.youtube.com/watch?v=UKkObvtycq8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
         },
        new Musica() {
            Id = 26,
            Título = "BITTERSUITE",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("4:58"),
            Spotify = "https://open.spotify.com/intl-pt/track/7DpUoxGSdlDHfqCYj0otzU",
            AppleMusic = "https://music.apple.com/br/song/bittersuite/1739659277",
            Youtube = "https://music.youtube.com/watch?v=5qIUoTIHwac&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
         },
        new Musica() {
            Id = 27,
            Título = "BLUE",
            Compositores = "Billie Eilish e Finneas O'Connell",
            Duracao = TimeSpan.Parse("5:43"),
            Spotify = "https://open.spotify.com/intl-pt/track/2prqm9sPLj10B4Wg0wE5x9",
            AppleMusic = "https://music.apple.com/br/song/blue/1739659278",
            Youtube = "https://music.youtube.com/watch?v=mZqiawnNCQg&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0"
         },

            new Musica() {
                Id = 28,
                Título = "Die With A Smile",
                Compositores = "Andrew Watt,Bruno Mars, Dernst Emile IIJames Faunt, leroy e Lady Gaga",
                Duracao = TimeSpan.Parse ("4:11"),
        Spotify = "https://open.spotify.com/intl-pt/track/2plbrEY59IikOBgBGLjaoe",
                AppleMusic = "https://music.apple.com/br/album/die-with-a-smile-single/1762656724",
                Youtube = "https://music.youtube.com/watch?v=kPa7bsKwL-c&si=bMVzjSb-hhGRsgQY"
            },
            new Musica() {
                Id = 29,
                Título = "Taste",
                Compositores = "Amy Allen, Ian Kirkpatrick, John Ryan, Julia Michaels e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:37"),
        Spotify = "https://open.spotify.com/intl-pt/track/5G2f63n7IPVPPjfNIGih7Q",
                AppleMusic = "https://music.apple.com/br/album/taste/1750307020?i=1750307079",
                Youtube = "https://music.youtube.com/watch?v=KEG7b851Ric&si=KRCelRKdDsTmFNk0"
            },
            new Musica() {
                Id = 30,
                Título = "Please Please Please",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:06"),
        Spotify = "https://open.spotify.com/intl-pt/track/2tHwzyyOLoWSFqYNjeVMzj?si=779dd46eb00c4d29",
                AppleMusic = "https://music.apple.com/br/album/please-please-please/1750307020?i=1750307080",
                Youtube = "https://music.youtube.com/watch?v=cF1Na4AIecM&si=Ct5BV2uaRkzQyZJS"
            },
            new Musica() {
                Id = 31,
                Título = "Good Graces",
                Compositores = "Amy Allen, Julia Michaels, John Ryan, Julian Bunetta e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:05"),
        Spotify = "https://open.spotify.com/intl-pt/track/102YUQbYmwdBXS7jwamI90?si=dee78dcff6c1468b",
                AppleMusic = "https://music.apple.com/br/album/good-graces/1750307020?i=1750307081",
                Youtube = "https://music.youtube.com/watch?v=alYCYZvB3yo&si=ECxbbLSlQKFR6_gu"
            },
            new Musica() {
                Id = 32,
                Título = "Sharpest Tool",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:38"),
        Spotify = "https://open.spotify.com/intl-pt/track/3iPIDAFybaoyqX7hvAfWkl?si=2a50e66fe6fa42a0",
                AppleMusic = "https://music.apple.com/br/album/sharpest-tool/1750307020?i=1750307082",
                Youtube = "https://music.youtube.com/watch?v=TuOwCuECUvM&si=RKdelYesnjvqUz58"
            },
            new Musica() {
                Id = 33,
                Título = "Coincidence",
                Compositores = "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:44"),
        Spotify = "https://open.spotify.com/intl-pt/track/5oIVNm56t6OIf9ZjdEG3ud?si=3ae5c699e46b4b37",
                AppleMusic = "https://music.apple.com/br/album/coincidence/1750307020?i=1750307084",
                Youtube = "https://music.youtube.com/watch?v=jbJhdc2zLz0&si=y5jHGgcKgWS2P67-"
            },
            new Musica() {
                Id = 34,
                Título = "Bed Chem",
                Compositores = "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:51"),
        Spotify = "https://open.spotify.com/intl-pt/track/1UHS8Rf6h5Ar3CDWRd3wjF?si=a961cb3290044147",
                AppleMusic = "https://music.apple.com/br/album/bed-chem/1750307020?i=1750307088",
                Youtube = "https://music.youtube.com/watch?v=x8VkB8ap_FQ&si=qEX7xZ6fetSszG1j"
            },
            new Musica() {
                Id = 35,
                Título = "Espresso",
                Compositores = "Amy Allen, Julian Bunetta, Steph Jones e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:55"),
        Spotify = "https://open.spotify.com/intl-pt/track/2HRqTpkrJO5ggZyyK6NPWz?si=b6ca528011d24c28",
                AppleMusic = "https://music.apple.com/br/album/espresso/1750307020?i=1750307362",
                Youtube = "https://music.youtube.com/watch?v=eVli-tstM5E&si=YR217Xcajos35f3f"
            },
            new Musica() {
                Id = 36,
                Título = "Dumb & Poetic",
                Compositores = "Amy Allen, John Ryan, Julia Michaels e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/5VhvD0AKRprEaFtPNKGBQR?si=eb1a88a7dd954a2c",
                AppleMusic = "https://music.apple.com/br/album/dumb-poetic/1750307020?i=1750307368",
                Youtube = "https://music.youtube.com/watch?v=moMdJBDCblE&si=Nfz-7Fbs4wdB3tZr"
            },
            new Musica() {
                Id = 37,
                Título = "Slim Pickins",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:32"),
        Spotify = "https://open.spotify.com/intl-pt/track/0XkZmBCCcdMY0EPY8ij6Gb?si=35c4c8d6e63a4a6f",
                AppleMusic = "https://music.apple.com/br/album/slim-pickins/1750307020?i=1750307371",
                Youtube = "https://music.youtube.com/watch?v=TmP-d1KQqQo&si=z1AbTQBWUYRXnFF8"
            },
            new Musica() {
                Id = 38,
                Título = "Juno",
                Compositores = "Amy Allen, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("4:11"),
        Spotify = "https://open.spotify.com/intl-pt/track/21B4gaTWnTkuSh77iWEXdS?si=4dba330e243c4896",
                AppleMusic = "https://music.apple.com/br/album/juno/1750307020?i=1750307372",
                Youtube = "https://music.youtube.com/watch?v=1aMCVgRKcP4&si=HZ7SkYc0NnMwKDqM"
            },
            new Musica() {
                Id = 39,
                Título = "Lie To Girls",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:22"),
        Spotify = "https://open.spotify.com/intl-pt/track/5il0jwWUlvgtIzWvzJi12z?si=ac92528c47f44a13",
                AppleMusic = "https://music.apple.com/br/album/lie-to-girls/1750307020?i=1750307375",
                Youtube = "https://music.youtube.com/watch?v=xYQT5qx1ROE&si=D7arwfmuEmqCGj-E"
            },
            new Musica() {
                Id = 40,
                Título = "Don't Smile",
                Compositores = "Amy Allen, John Ryan, Julian Bunetta e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:26"),
        Spotify = "https://open.spotify.com/intl-pt/track/09LrGvT9KsACH66RHYMDyR?si=db4eb49cb20f46fc",
                AppleMusic = "https://music.apple.com/br/album/dont-smile/1750307020?i=1750307379",
                Youtube = "https://music.youtube.com/watch?v=Ju9X2HMMid4&si=2BIy_n2EDrhuo7eM"
            },
            new Musica() {
                Id = 41,
                Título = "american dream",
                Compositores = "BK Rube, Isaiah Brown, James Owens, Sterling White",
                Duracao = TimeSpan.Parse ("1:03"),
        Spotify = "https://open.spotify.com/intl-pt/track/4yreExU3eRNTe2iJz6X6k3?si=f362a1073ea74d90",
                AppleMusic = "https://music.apple.com/br/album/american-dream/1724494274?i=1724494706",
                Youtube = "https://music.youtube.com/watch?v=xH3nqcOA2DA&si=d0GuF0QRkilMEPlV"
            },
            new Musica() {
                Id = 42,
                Título = "all of me",
                Compositores = "Billie Rae Calvin, Isaiah Brown, Jalen Jackson, Jared Brown, Khaya Gilika, Raphael Oliveira, Shéyaa Bin Abraham-Joseph, Sterling White Jr. e Yakki Davis",
                Duracao = TimeSpan.Parse ("3:18"),
        Spotify = "https://open.spotify.com/intl-pt/track/2FoahzOSxJnalPA8aBUme3?si=4dcf0ff36dfc41bf",
                AppleMusic = "https://music.apple.com/br/album/all-of-me/1724494274?i=1724494713",
                Youtube = "https://music.youtube.com/watch?v=UpYb4C2--UY&si=SLZyVKaMHj_L5Iqu"
            },
            new Musica() {
                Id = 43,
                Título = "redrum",
                Compositores = "London Tyler Holmes, Mateen Kyle Niknam, Shéyaa Bin Abraham-Joseph e Vinícius de Moraes",
                Duracao = TimeSpan.Parse ("4:30"),
        Spotify = "https://open.spotify.com/intl-pt/track/52eIcoLUM25zbQupAZYoFh?si=6e6e2de7c6424585",
                AppleMusic = "https://music.apple.com/br/album/redrum/1724494274?i=1724494724",
                Youtube = "https://music.youtube.com/watch?v=U4mADkt6o-M&si=3Q_fwieZCwEz5AK7"
            },
            new Musica() {
                Id = 44,
                Título = "n.h.i.e",
                Compositores = "Anthony Paul Jefferies, Amala Dlamini, Douglas Ford, Jonah Stevens, Kurtis McKenzie, Michael Orabiyi e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("2:23"),
        Spotify = "https://open.spotify.com/intl-pt/track/6x9pCndnXEoea0CMcfjs9W?si=77313696de6c4d69",
                AppleMusic = "https://music.apple.com/br/album/n-h-i-e/1724494274?i=1724494847",
                Youtube = "https://music.youtube.com/watch?v=xDmb610okx0&si=LR6vKS48X8AKKR4n"
            },
            new Musica() {
                Id = 45,
                Título = "sneaky",
                Compositores = "Edward Maclin Cooper III e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:21"),
        Spotify = "https://open.spotify.com/intl-pt/track/2K7sv1mno9PvbXVBpqvSKn?si=ca4fc57f5aa046c5",
                AppleMusic = "https://music.apple.com/br/album/sneaky/1724494274?i=1724494853",
                Youtube = "https://music.youtube.com/watch?v=gnwBjjXjuH4&si=WL2v7DfHg7SPtkz2"
            },
            new Musica() {
                Id = 46,
                Título = "Family Matters",
                Compositores = "A. Graham",
                Duracao = TimeSpan.Parse ("7:36"),
        Spotify = "https://open.spotify.com/intl-pt/track/1wFFFzJ5EsKbBWZriAcubN?si=db2108699e654142",
                AppleMusic = "https://music.apple.com/br/album/family-matters/1744684618?i=1744684622",
                Youtube = "https://music.youtube.com/watch?v=ZkXG3ZrXlbc&si=PxyMmF1rflZ2L1JI"
            },
            new Musica() {
                Id = 47,
                Título = "pop ur shit",
                Compositores = "Allen Ritter, Jeffery Lamar Williams, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/47yD0e9MCRIB8dgUXPfyW3?si=452a79acf0d14699",
                AppleMusic = "https://music.apple.com/br/album/pop-ur-shit/1724494274?i=1724494854",
                Youtube = "https://music.youtube.com/watch?v=GnhJziHDzCg&si=n3DpCY13siLvdWgM"
            },
            new Musica() {
                Id = 48,
                Título = "letter to my brudda",
                Compositores = "Kavi Lybarger, Paola Barba, Park Min Geon, Shéyaa Bin Abraham-Joseph, Tchakalla Anthony Romeo, Tyrese McGriff e William Boyette",
                Duracao = TimeSpan.Parse ("2:39"),
        Spotify = "https://open.spotify.com/intl-pt/track/5P1z8XwsCStb74emERTx9v?si=89a85f813b8846fe",
                AppleMusic = "https://music.apple.com/br/album/letter-to-my-brudda/1724494274?i=1724494860",
                Youtube = "https://music.youtube.com/watch?v=jBnzs_UMtGk&si=w3G787ZuJv15PhZT"
            },
            new Musica() {
                Id = 49,
                Título = "dangerous",
                Compositores = "Durk Banks, Jahmal Gwin, Jahshua Brown, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("4:25"),
        Spotify = "https://open.spotify.com/intl-pt/track/0fyP96TikhD9sM4eKqw5Yp?si=1c60bf3ca1e047a0",
                AppleMusic = "https://music.apple.com/br/album/dangerous/1724494274?i=1724494865",
                Youtube = "https://music.youtube.com/watch?v=Gy6urUcig5A&si=CayiEMOdzvNBJ5Xt"
            },
            new Musica() {
                Id = 50,
                Título = "née-nah",
                Compositores = "Douglas Ford, Jacques Webster, Leland Tyler Wayne, Malcolm McLaren, Rodney Argent, Shéyaa Bin Abraham-Joseph e William Handy",
                Duracao = TimeSpan.Parse ("3:40"),
        Spotify = "https://open.spotify.com/intl-pt/track/2yUzr8Sr6ldG8vmHhZwTnz?si=88ef52cb03f445de",
                AppleMusic = "https://music.apple.com/br/album/n%C3%A9e-nah/1724494274?i=1724494870",
                Youtube = "https://music.youtube.com/watch?v=hSitXYlIqKI&si=buF2LOhcYZmawLRH"
            },
            new Musica() {
                Id = 51,
                Título = "see the real",
                Compositores = "Dylan Cleary-Krell, Joshua Parker, Jason Cornet, Jocelyn Donald, Jordan Holt-May, Samuel David Jimenez e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/4E64eAph6AYI98ucunrGH8?si=fb8bc79e7f6943a0",
                AppleMusic = "https://music.apple.com/br/album/see-the-real/1724494274?i=1724494876",
                Youtube = "https://music.youtube.com/watch?v=InwWpxgt6DE&si=B-BSGVTKu6kQIY1p"
            },
            new Musica() {
                Id = 52,
                Título = "prove it",
                Compositores = "Carl Thompson, Edward Maclin Cooper III, Faith Evans, Isaiah Brown, James Owens,Keith Thomas, Shéyaa Bin Abraham-Joseph, Summer Walker, Tauren kngs Stovall e Tye Beats",
                Duracao = TimeSpan.Parse ("3:27"),
        Spotify = "https://open.spotify.com/intl-pt/track/5wttBUDyaHAR5q9fYnN3YF?si=3074cc7786e94921",
                AppleMusic = "https://music.apple.com/br/album/prove-it/1724494274?i=1724495061",
                Youtube = "https://music.youtube.com/watch?v=oa8kjoT-MrM&si=cWMoHjuEPd02CwLU"
            },
            new Musica() {
                Id = 53,
                Título = "should've wore a bonnet",
                Compositores = "Ronald LaTour, Christopher Wood, Darryl Pearson, Daveon Jackson, David Patino, Donald Earle De Grate Jr Francis Esteban, Joel Hailey, John Julian e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:06"),
        Spotify = "https://open.spotify.com/intl-pt/track/4Xzq2WibDHR5Eufi21HlEZ?si=24153cc7554b496f",
                AppleMusic = "https://music.apple.com/br/album/shouldve-wore-a-bonnet/1724494274?i=1724495063",
                Youtube = "https://music.youtube.com/watch?v=EGJ7lxoRhlA&si=ZgOT4RzZk5MPN7lm"
            },
            new Musica() {
                Id = 54,
                Título = "just like me",
                Compositores = "Isaac De Boni, Michael Mule, Akeel Henry, Damini Ebunoluwa Ogulu, Jahmal Gwin, Jordon Manswell, Kevin Ekofo, Khadijah Lopez, Kira Huszar, Leland Tyler Wayne, Nevon Sinclair e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:51"),
        Spotify = "https://open.spotify.com/intl-pt/track/5KI7I4mEtulXcv5VQJaV35?si=2e63f26a441844d8",
                AppleMusic = "https://music.apple.com/br/album/just-like-me/1724494274?i=1724495068",
                Youtube = "https://music.youtube.com/watch?v=lgj851mZcfA&si=u60cjiwLuEVSovP5"
            },
            new Musica() {
                Id = 55,
                Título = "red sky",
                Compositores = "4th Pyramid, Carlton Davis Mays, Jr.,Courtney Dwight, John Stephen Sudduth, Shaan Ramaprasad, Shéyaa Bin Abraham-Joseph e Tommy Newport",
                Duracao = TimeSpan.Parse ("2:56"),
        Spotify = "https://open.spotify.com/intl-pt/track/4yLyVdEqV790aIXyGif85v?si=f5b4bfcff3604f52",
                AppleMusic = "https://music.apple.com/br/album/red-sky/1724494274?i=1724495070",
                Youtube = "https://music.youtube.com/watch?v=5_-sIkbYd_M&si=KvXwtEY0gvHd7uBM"
            },
            new Musica() {
                Id = 56,
                Título = "dark days",
                Compositores = "Ahmar Bailey, Atia Boggs, JONAS LEE, Kavi Lybarger,Mariah Buckles, Paola Madelaine Barba Amado, Shéyaa Bin Abraham-Joseph, Yakki Davis e Yousef Sameh",
                Duracao = TimeSpan.Parse ("4:55"),
        Spotify = "https://open.spotify.com/intl-pt/track/02Cp3VTUWNed8hr69BhKz6?si=7925d9440a6b467f",
                AppleMusic = "https://music.apple.com/br/album/dark-days/1724494274?i=1724495073",
                Youtube = "https://music.youtube.com/watch?v=CiFxS8JaUfM&si=ZX5084H4Jb7neQC8"
            },
            new Musica() {
                Id = 57,
                Título = "Not Like Us",
                Compositores = "Kendrick LamarRay Charles e Sean Momberger",
                Duracao = TimeSpan.Parse ("4:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/6AI3ezQ4o3HUoP6Dhudph3?si=b8dca7f0f8354702",
                AppleMusic = "https://music.apple.com/br/album/not-like-us/1781353928?i=1781353929",
                Youtube = "https://music.youtube.com/watch?v=phLb_SoPBlA&si=pqlYAoGqNFjwLXSk"
            },
            new Musica() {
                Id = 58,
                Título = "HYAENA",
                Compositores = "Mike Dean, Noah Goldstein, Andy Votel, Derek Shulman, Ebony Oshunrinde, Edward Hazel, George Clinton, Jacques Webster, Jahaan Sweet, Kerry Minnear e Ray Shulman",
                Duracao = TimeSpan.Parse ("3:42"),
        Spotify = "https://open.spotify.com/intl-pt/track/0hL9gOw6XBWsygEUcVjxEc?si=fd1cf4efcfe345bc",
                AppleMusic = "https://music.apple.com/br/album/hyaena/1699712635?i=1699712637",
                Youtube = "https://music.youtube.com/watch?v=N20q-391r48&si=aik_98jTi19G-E35"
            },
            new Musica() {
                Id = 59,
                Título = "THANK GOD",
                Compositores = "Allen Ritter, Ebony Oshunrinde, Finatik(of FNZ), Zac(of FNZ), Isaac Boni, Jacques Webster, Jahmal Gwin, Mark Mbogo, Micheal Mule, Stormi Webster e Ye",
                Duracao = TimeSpan.Parse ("3:04"),
        Spotify = "https://open.spotify.com/intl-pt/track/1PH2MDbcBAU094DlgTIND1?si=3b17478bf986451d",
                AppleMusic = "https://music.apple.com/br/album/thank-god/1699712635?i=1699712638",
                Youtube = "https://music.youtube.com/watch?v=UVtTc4zqbxQ&si=UqaAdmHLIggAy48d"
            },
            new Musica() {
                Id = 60,
                Título = "MODERN JAM (feat. Teezo Touchdown)",
                Compositores = "Mike Dean, Aaron Thomas, Guy-Manuel de Homem, Jacques Webster e Jahaan Sweet",
                Duracao = TimeSpan.Parse ("4:15"),
        Spotify = "https://open.spotify.com/intl-pt/track/3KCNiDi9Pza6ZD8FggNoaw?si=87a05d35086b4b1d",
                AppleMusic = "https://music.apple.com/br/album/modern-jam-feat-teezo-touchdown/1699712635?i=1699712643",
                Youtube = "https://music.youtube.com/watch?v=g8IvO7OwdaM&si=sHLaSerO7bIgc4OP"
            },
            new Musica() {
                Id = 61,
                Título = "MY EYES",
                Compositores = "Josiah Sherman, Wesley Glass,Dua Saleh, Ebony Oshunrinde, Jacques Webster, Joseph Thornalley, Justin Vernon, Phil Cook e Sampha Sisay ",
                Duracao = TimeSpan.Parse ("4:11"),
        Spotify = "https://open.spotify.com/intl-pt/track/4kjI1gwQZRKNDkw1nI475M?si=f041f16fa3cb41e6",
                AppleMusic = "https://music.apple.com/br/album/my-eyes/1699712635?i=1699712644",
                Youtube = "https://music.youtube.com/watch?v=pildU9lK6vM&si=-LbHFPpS4QCGSa1e"
            },
            new Musica() {
                Id = 62,
                Título = "GOD'S COUNTRY",
                Compositores = "Dez Wright, Samuel Gloade, Jacques Webster e Ye ",
                Duracao = TimeSpan.Parse ("2:07"),
        Spotify = "https://open.spotify.com/intl-pt/track/04WxWo7XeVyx22xEsrWRUb?si=34148e061c8942be",
                AppleMusic = "https://music.apple.com/br/album/gods-country/1699712635?i=1699712646",
                Youtube = "https://music.youtube.com/watch?v=E9VVEdw5Dng&si=tpz7f-KYteNMrrKN"
            },
            new Musica() {
                Id = 63,
                Título = "SIRENS",
                Compositores = "Josiah Sherman, Noah Goldstein, Psymun, Ebony Oshunrinde, Isaac Mpofu, Jacques Webster, Jahaan Sweet, John Fannon, Keith Kawbe e Evan mast",
                Duracao = TimeSpan.Parse ("3:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/7LSpFCvRZZot2AlmkUzy9k?si=3c3b221b2fa146fd",
                AppleMusic = "https://music.apple.com/br/album/sirens/1699712635?i=1699712647",
                Youtube = "https://music.youtube.com/watch?v=6gUiQ8CqLcY&si=u4S6n119zOmBNtqT"
            },
            new Musica() {
                Id = 64,
                Título = "MELTDOWN (feat. Drake)",
                Compositores = "ANDERSON HERNANDEZ, Brytavious Chambers, Coleman, Matthew Samuels, A. Graham, Benjamin Saint Fort e Jacques Webster",
                Duracao = TimeSpan.Parse ("4:06"),
        Spotify = "https://open.spotify.com/intl-pt/track/67nepsnrcZkowTxMWigSbb?si=01448f585c8a40d5",
                AppleMusic = "https://music.apple.com/br/album/meltdown-feat-drake/1699712635?i=1699712649",
                Youtube = "https://music.youtube.com/watch?v=LuKm4L9ryB0&si=t9yAnLlfbZd3zePd"
            },
            new Musica() {
                Id = 65,
                Título = "FE!N (feat. Playboi Carti)",
                Compositores = "Jahaan Sweet, Jacques Webster, Jordan Carter e Khadimou Fall",
                Duracao = TimeSpan.Parse ("3:11"),
        Spotify = "https://open.spotify.com/intl-pt/track/42VsgItocQwOQC3XWZ8JNA?si=6eb554e558b4426e",
                AppleMusic = "https://music.apple.com/br/album/fe-n-feat-playboi-carti/1699712635?i=1699712651",
                Youtube = "https://music.youtube.com/watch?v=B9synWjqBn8&si=lqdU6AoMhcy5dY3G"
            },
            new Musica() {
                Id = 66,
                Título = "DELRESTO (ECHOES) (feat. Beyoncé)",
                Compositores = "Allen Ritter, Chauncey Hollis, MIke Dean, Beyoncé, Jacques Webster, James Blake e Terius Gesteelde-Diamant",
                Duracao = TimeSpan.Parse ("4:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/0OEe83mMZ5kaNw5uZQ7ilG?si=c8e91268170245ff",
                AppleMusic = "https://music.apple.com/br/album/delresto-echoes-feat-beyonc%C3%A9/1699712635?i=1699712652",
                Youtube = "https://music.youtube.com/watch?v=vM34QWOrz4A&si=8KI7cVKZb-88ypMs"

            },
            new Musica() {
                Id = 67,
                Título = "I KNOW ?",
                Compositores = "Josiah Sherman, Ozan Yildrim, Scotty Coleman, Jacques Webster, Kobe Hood e Terrance George",
                Duracao = TimeSpan.Parse ("3:31"),
        Spotify = "https://open.spotify.com/intl-pt/track/6wsqVwoiVH2kde4k4KKAFU?si=9a584bbedb1a49f3",
                AppleMusic = "https://music.apple.com/br/album/i-know/1699712635?i=1699712653",
                Youtube = "https://music.youtube.com/watch?v=X7aF3nZOS98&si=2ZBLmlOBdD-s_x8B"
            },
            new Musica() {
                Id = 68,
                Título = "TOPIA TWINS (feat. Rob49 & 21 Savage)",
                Compositores = "Dez Wright, Wesley Glass, Cash Esmailian,Douglas Ford, Harry Edwards, Henri Velasco, Jacques Webster, Oliver Rodigan, Robert Thomas e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:43"),
        Spotify = "https://open.spotify.com/intl-pt/track/0lodMO0qK83vfPiiD7FMEt?si=ff6685695b0f4661",
                AppleMusic = "https://music.apple.com/br/album/topia-twins-feat-rob49-21-savage/1699712635?i=1699712655",
                Youtube = "https://music.youtube.com/watch?v=BsHcPP9KQdU&si=NoBXPJu5Lcdkk2tv"
            },
            new Musica() {
                Id = 69,
                Título = "CIRCUS MAXIMUS (feat. The Weeknd & Swae Lee)",
                Compositores = "Noah Goldstein, Abel Tesfaye, Ebony Oshunrinde, Gary Klebe, Jacques Webster, Jahaan Sweet, Khalif Brown e Mike Dean",
                Duracao = TimeSpan.Parse ("4:18"),
        Spotify = "https://open.spotify.com/intl-pt/track/4GL9GMX9t7Qkprvf1YighZ?si=7d37e9b3349c49b2",
                AppleMusic = "https://music.apple.com/br/album/circus-maximus-feat-the-weeknd-swae-lee/1699712635?i=1699712656",
                Youtube = "https://music.youtube.com/watch?v=BwhRWpHxKdM&si=cYJQ7AFEQBKTdGTM"
            },
            new Musica() {
                Id = 70,
                Título = "PARASAIL (feat. Yung Lean & Dave Chappelle)",
                Compositores = "Buddy Ross, Jahaan Sweet, Noah Goldstein, Anthony Ruiz, Dave Bixby, David Chappelle, Jacques Webster, Jonatan Håsted e Joseph Thornalley",
                Duracao = TimeSpan.Parse ("2:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/2Q0aElTZQtEUsoiaQfizu6?si=136ad3df1be44995",
                AppleMusic = "https://music.apple.com/br/album/parasail-feat-yung-lean-dave-chappelle/1699712635?i=1699712657",
                Youtube = "https://music.youtube.com/watch?v=aEiD3UZDmiY&si=DCQTuyv1dsQLVB-s"
            },
            new Musica() {
                Id = 71,
                Título = "SKITZO (feat. Young Thug)",
                Compositores = "Dylan Teixeira, Matthew Samuels, Scotty Coleman, Sevn Thomas, Blue Miller, Douglas Ford, Ebony Oshunrinde, India Simpson, Jacques Webster, Jahaan Sweet, Jeffrey Williams, Nami Ondas, Nik Dean, Slim Pharoah e Travis Sayles",
                Duracao = TimeSpan.Parse ("6:06"),
        Spotify = "https://open.spotify.com/intl-pt/track/0bkV1iQHSxBaksUqgEkcbc?si=30f1f7458f424794",
                AppleMusic = "https://music.apple.com/br/album/skitzo-feat-young-thug/1699712635?i=1699712660",
                Youtube = "https://music.youtube.com/watch?v=Zk-4WvSPpac&si=bTYs5izCSgIPdmX-"
            },
            new Musica() {
                Id = 72,
                Título = "LOST FOREVER (feat. Westside Gunn)",
                Compositores = "Alan Maman, Alvin Worthy, Dominic Maker, Douglas Ford, Elliott Baker, Jacques Webster e James Litherland",
                Duracao = TimeSpan.Parse ("2:43"),
        Spotify = "https://open.spotify.com/intl-pt/track/7EiUtdeoWcKqLi5ELZCjYf?si=d184061f602f474b",
                AppleMusic = "https://music.apple.com/br/album/lost-forever-feat-westside-gunn/1699712635?i=1699712661",
                Youtube = "https://music.youtube.com/watch?v=AppJbl-wODs&si=E196LCdbPfhommXf"
            },
            new Musica() {
                Id = 73,
                Título = "LOOOVE (feat. Kid Cudi)",
                Compositores = "Buddy Ross, Jacques Webster, Pharrell Williams e Scott Mescudi",
                Duracao = TimeSpan.Parse ("3:46"),
        Spotify = "https://open.spotify.com/intl-pt/track/0a4SMs889NwP8oWI7Vemle?si=86ab55a806e44995",
                AppleMusic = "https://music.apple.com/br/album/looove-feat-kid-cudi/1699712635?i=1699712662",
                Youtube = "https://music.youtube.com/watch?v=tPdPgFhdp58&si=a1wpujn9PmhKos6O"
            },
            new Musica() {
                Id = 74,
                Título = "K-POP (feat. Bad Bunny & The Weeknd)",
                Compositores = "Bigram John Zayas, Carlo Montagnese, Jahaan Sweet, Matthew Samuels, Abel Tesfaye, Benito Antonio Martínez Ocasio, Benjamin Saint Fort e Jacques Webster",
                Duracao = TimeSpan.Parse ("3:05"),
        Spotify = "https://open.spotify.com/intl-pt/track/4o82J5zr4DFEs9yj5szCVX?si=87917e1dfcfd4892",
                AppleMusic = "https://music.apple.com/br/album/k-pop-feat-bad-bunny-the-weeknd/1699712635?i=1699712663",
                Youtube = "https://music.youtube.com/watch?v=_kS7F4VpJa0&si=YD2f9XolQuM5_Ng8"
            },
            new Musica() {
                Id = 75,
                Título = "TELEKINESIS (feat. SZA & Future)",
                Compositores = "Edgar Nabeyin Pandord, Jacques Webster, Jahaan Sweet, Jahmal Gwin, Nayvadius Wilburn, Nima Jahanbin, Paimon Jahanbin, Solana Rowe, Victory Boyd e Ye",
                Duracao = TimeSpan.Parse ("5:53"),
        Spotify = "https://open.spotify.com/intl-pt/track/1i9lZvlaDdWDPyXEE95aiq?si=3d84e6abb37e4a9a",
                AppleMusic = "https://music.apple.com/br/album/telekinesis-feat-sza-future/1699712635?i=1699712664",
                Youtube = "https://music.youtube.com/watch?v=zptRsa1pqsk&si=WVocK7o1SZe3fPZI"
            },
            new Musica() {
                Id = 76,
                Título = "TIL FURTHER NOTICE (feat. James Blake & 21 Savage)",
                Compositores = "Jacques Webster, James Litherland, Leland Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("5:14"),
        Spotify = "https://open.spotify.com/intl-pt/track/76gcXhY3Zv6wW0BTe9nHJo?si=8c00b0ac3a1d403e",
                AppleMusic = "https://music.apple.com/br/album/til-further-notice-feat-james-blake-21-savage/1699712635?i=1699712667",
                Youtube = "https://music.youtube.com/watch?v=zptRsa1pqsk&si=8W45t0fmrNacgXLd"
            },
            new Musica() {
                Id = 77,
                Título = "Crack com Mussilon",
                Compositores = "Citação: Oceano - Djavan, Djavan e Matuê",
                Duracao = TimeSpan.Parse ("2:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/4ssHL7bSnOAE7HjiuLx6Co",
            AppleMusic = "https://music.apple.com/br/song/crack-com-mussilon/1767049265",
            Youtube = "https://music.youtube.com/watch?v=zctKiN-okXI&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 78,
                Título = "Imagina esse Cenário",
                Compositores = "Matuê e Veigh",
                Duracao = TimeSpan.Parse ("2:35"),
        Spotify = "https://open.spotify.com/intl-pt/track/2fjqfFUq64thFsqfKN01kS",
            AppleMusic = "https://music.apple.com/br/song/imagina-essecen%C3%A1rio/1767049268",
            Youtube = "https://music.youtube.com/watch?v=Leep9KouXMo&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },

            new Musica() {
                Id = 79,
                Título = "Isso é Sério",
                Compositores = "Brandão85 e Matuê",
                Duracao = TimeSpan.Parse ("4:45"),
        Spotify = "https://open.spotify.com/intl-pt/track/3Sa2gVQioE31DcG4nKNDqD",
            AppleMusic = "https://music.apple.com/br/album/isso-%C3%A9-s%C3%A9rio/1767049264?i=1767049270",
            Youtube = "https://music.youtube.com/watch?v=d-6DzlhlBxA&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 80,
                Título = "1993",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("2:07"),
        Spotify = "https://open.spotify.com/intl-pt/track/6QsHhB0W9GtLF3cI7mUVkQ",
            AppleMusic = "https://music.apple.com/br/song/1993/1767049273",
            Youtube = "https://music.youtube.com/watch?v=gyVmdwtvKwg&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 81,
                Título = "4Tal",
                Compositores = "Matuê e Teto",
                Duracao = TimeSpan.Parse ("3:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/6OcZP4rUfuxms2r8Mwx5BQ",
            AppleMusic = "https://music.apple.com/br/song/4tal/1767049274",
            Youtube = "https://music.youtube.com/watch?v=mr_AunTy2pk&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 82,
                Título = "O Som",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("5:12"),
        Spotify = "https://open.spotify.com/intl-pt/track/4v0VOuuaZSQHjnjzkC3cnk",
            AppleMusic = "https://music.apple.com/br/song/o-som/1767049277",
            Youtube = "https://music.youtube.com/watch?v=iEb-OKbn-w8&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 83,
                Título = "04AM",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:19"),
        Spotify = "https://open.spotify.com/intl-pt/track/2fTTmjyF7pfarDBAbsJkvb",
            AppleMusic = "https://music.apple.com/br/song/04am/1767049401",
            Youtube = "https://music.youtube.com/watch?v=-bYNcpEBY9E&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 84,
                Título = "Castlevania",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:50"),
        Spotify = "https://open.spotify.com/intl-pt/track/3Kh5a6vXMiJtC35jMEfmyy",
            AppleMusic = "https://music.apple.com/br/song/castlevania/1767049403",
            Youtube = "https://music.youtube.com/watch?v=A4FRq2QK6mw&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id =  85,
                Título = "V de Vilão",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("2:26"),
        Spotify = "https://open.spotify.com/intl-pt/track/7pMfMzfYSTbNxj5lJEbQIp",
            AppleMusic = "https://music.apple.com/br/song/v-de-vil%C3%A3o/1767049407",
            Youtube = "https://music.youtube.com/watch?v=QGSdmEsv4G0&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 86,
                Título = "Maria",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/2ux3Sb90r5aA74nLMls1u0",
            AppleMusic = "https://music.apple.com/br/song/maria/1767049408",
            Youtube = "https://music.youtube.com/watch?v=-x2cE--r3L8&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 87,
                Título = "333",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("5:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/0qsKefQyXCzaxjHbOcd8IU",
            AppleMusic = "https://music.apple.com/br/song/333/1767049409",
            Youtube = "https://music.youtube.com/watch?v=aq-DH4iwviE&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 88,
                Título = "Like This!",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:28"),
        Spotify = "https://open.spotify.com/intl-pt/track/49gGZLLm1d7fBFQkTqskXo",
            AppleMusic = "https://music.apple.com/br/song/like-this/1767049410",
            Youtube = "https://music.youtube.com/watch?v=0zamf27iJ1E&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A"
            },
            new Musica() {
                Id = 89,
                Título = "Medo de Quem?",
                Compositores = "msahlholdt, RUXN e WIU",
                Duracao = TimeSpan.Parse ("2:54"),
        Spotify = "https://open.spotify.com/intl-pt/track/5EKCczncKlpSmDoP074cVF?si=bd980e97ceac47ee",
                AppleMusic = "https://music.apple.com/br/album/medo-de-quem/1755821257?i=1755821259",
                Youtube = "https://music.youtube.com/watch?v=O1AD591l-3Y&si=P7pgSsJLLsCgz6zn"
            },
            new Musica() {
                Id = 90,
                Título = "Casa do Tio Wiu",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/2umpEVeKbYxx1Qx2Dy1mcz?si=528997fb07824862",
                AppleMusic = "https://music.apple.com/br/album/casa-do-tio-wiu/1755821257?i=1755821262",
                Youtube = "https://music.youtube.com/watch?v=MXf6fcSLUyU&si=Wth2jKGkGXM5-jZV"
            },
            new Musica() {
                Id = 91,
                Título = "Rainha da Finesse",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("2:46"),
        Spotify = "https://open.spotify.com/intl-pt/track/0w7vodPWFEcuEYvWpbNbOu?si=2468dd3b313248b4",
                AppleMusic = "https://music.apple.com/br/album/rainha-da-finesse/1755821257?i=1755821263",
                Youtube = "https://music.youtube.com/watch?v=dC6NPbqJV6k&si=8x-hIFTVccdbi0DM"
            },
            new Musica() {
                Id = 92,
                Título = "Vidigal",
                Compositores = "BlueFire, WIU e Yako",
                Duracao = TimeSpan.Parse ("3:17"),
        Spotify = "https://open.spotify.com/intl-pt/track/42XLOKRo2bv2Ne9lTOGSQA?si=ecaff77709804ed1",
                AppleMusic = "https://music.apple.com/br/album/vidigal/1755821257?i=1755821267",
                Youtube = "https://music.youtube.com/watch?v=Zpe-s1ROP50&si=ZrHEDo6FYvZfaGi6"
            },
            new Musica() {
                Id = 93,
                Título = "Amor de 1h",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:28"),
        Spotify = "https://open.spotify.com/intl-pt/track/688p6uyAS8MBxWSfExaXx5?si=738ed23c7c5c4ea9",
                AppleMusic = "https://music.apple.com/br/album/amor-de-1h/1755821257?i=1755821268",
                Youtube = "https://music.youtube.com/watch?v=cy6K9SLa8h4&si=INI3F5VjNeWx0jwX"
            },
            new Musica() {
                Id = 94,
                Título = "Se eu ver sua mãe na rua",
                Compositores = "Saint Blunts e WIU",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/2ifEk0oT5FYOLIsvjvdxIK?si=c9b26407581e42ff",
                AppleMusic = "https://music.apple.com/br/album/se-eu-ver-sua-m%C3%A3e-na-rua/1755821257?i=1755821419",
                Youtube = "https://music.youtube.com/watch?v=7Jv-PLTy6WA&si=6wDTEWgCa01GQKYs"
            },
            new Musica() {
                Id = 95,
                Título = "desgraçadagostosamaldita",
                Compositores = "Desro, Dragzi, Moras e WIU",
                Duracao = TimeSpan.Parse ("3:00"),
        Spotify = "https://open.spotify.com/intl-pt/track/1Goev6cA7GPslY2CdxXzDG?si=ae19d108602a43dc",
                AppleMusic = "https://music.apple.com/br/album/desgra%C3%A7adagostosamaldita/1755821257?i=1755821420",
                Youtube = "https://music.youtube.com/watch?v=9p4M9Jc8CT8&si=Mlsmuamsf4w4jGqz"
            },
            new Musica() {
                Id = 96,
                Título = "Teimosa",
                Compositores = "AK On De Beat, Stoneraider e WIU",
                Duracao = TimeSpan.Parse ("3:03"),
        Spotify = "https://open.spotify.com/intl-pt/track/3FcxqTlyvhCNH0j3gxWy8u?si=8176ba72b1704bbd",
                AppleMusic = "https://music.apple.com/br/album/teimosa/1755821257?i=1755821421",
                Youtube = "https://music.youtube.com/watch?v=1_djuKtQHG8&si=zSxrN9mx6j-4yP1D"
            },
            new Musica() {
                Id = 97,
                Título = "Olha oq ce fez comigo",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:28"),
        Spotify = "https://open.spotify.com/intl-pt/track/5SD6Hqq4oI64KSfAyEUrRV?si=578747aa05a84359",
                AppleMusic = "https://music.apple.com/br/album/olha-oq-ce-fez-comigo/1755821257?i=1755821424",
                Youtube = "https://music.youtube.com/watch?v=iNOyX10Nqgc&si=p5LZRSmjwishroCK"
            },
            new Musica() {
                Id = 98,
                Título = "Guala",
                Compositores = "INQBOI BEATZ e WIU",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/5emXCWhIK8qnUJeB2CCcIl?si=827631d0c804414a",
                AppleMusic = "https://music.apple.com/br/album/guala/1755821257?i=1755821427",
                Youtube = "https://music.youtube.com/watch?v=plRxytI9hvo&si=Ug2SPfeA-0Ja0g90"
            },
            new Musica() {
                Id = 99,
                Título = "Maria do Olho Verde",
                Compositores = "RRareBear e WIU",
                Duracao = TimeSpan.Parse ("3:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/6c5AQO3llPWxeAK4b3cAut?si=74599532ff394d8e",
                AppleMusic = "https://music.apple.com/br/album/maria-do-olho-verde/1755821257?i=1755821428",
                Youtube = "https://music.youtube.com/watch?v=cD0tBkCG9AI&si=j4FbxZ-CipsGJUKB"
            },
            new Musica() {
                Id = 100,
                Título = "Eu Não Ouço Mais Trap",
                Compositores = "Cheek, Hulls e WIU",
                Duracao = TimeSpan.Parse ("3:16"),
        Spotify = "https://open.spotify.com/intl-pt/track/54mhCPc4XuWiv7aaFBqTAk?si=246db7ec7ccc434b",
                AppleMusic = "https://music.apple.com/br/album/eu-n%C3%A3o-ou%C3%A7o-mais-trap/1755821257?i=1755821430",
                Youtube = "https://music.youtube.com/watch?v=z5R9JzNpvPc&si=zmF2DvFPtPgnb5CT"
            },
            new Musica() {
                Id = 101,
                Título = "Rolê de Sempre",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("5:32"),
        Spotify = "https://open.spotify.com/intl-pt/track/1IA7U01tZDZmMarnf9QIa4?si=ec68be502f2b4ff8",
                AppleMusic = "https://music.apple.com/br/album/rol%C3%AA-de-sempre/1755821257?i=1755821431",
                Youtube = "https://music.youtube.com/watch?v=bDOVDVgEJl4&si=d8VtI4W051y6ZWDI"
            },
            new Musica() {
                Id = 102,
                Título = "Euphoria",
                Compositores = "Cardo, Kenneth Gamble, Jordan Houston, Kendrick Lamar, Leon Huff e Paul Beauregard",
                Duracao = TimeSpan.Parse("6:23"),
        Spotify = "https://open.spotify.com/intl-pt/track/77DRzu7ERs0TX3roZcre7Q?si=1dc67c5f16d0400e",
                AppleMusic = "https://music.apple.com/br/album/euphoria/1744024729?i=1744024751",
                Youtube = "https://music.youtube.com/watch?v=fAqa1ozCuj8&si=cHwY_Lb-Ps-q9GKU"
            },
                    new Musica() {
                Id = 103,
                Título = "WOKE UP",
                Compositores = "Chancellor´, JAEYOUNG, JAKOPS, LYRICKS e Shintaro Yasuda",
                Duracao = TimeSpan.Parse ("3:08"),
        Spotify = "https://open.spotify.com/intl-pt/album/2e9eizo3Euh2aaBef2B2bw?highlight=spotify:track:4keuUM29CtIWgsPRzRhXoW",
        AppleMusic = "https://music.apple.com/br/album/woke-up-single/1742262122",
        Youtube = "https://music.youtube.com/watch?v=Q06IepqwpVc&si=IfuwwE3G4tEb-wsU"
            },
            new Musica() {
                Id = 104,
                Título = "MTG QUERO VER SE VOCÊ TEM ATITUDE",
                Compositores = "Luan Gabriel",
                Duracao = TimeSpan.Parse ("1:57"),
        Spotify = "https://open.spotify.com/intl-pt/track/4PDw1XpsurgUnN7YSZmh1Q?si=f03b26626a09443f",
        Youtube = "https://music.youtube.com/watch?v=Ahr9n7xjNDg&si=sGTIz79UMzLfrHwa"
            },
            new Musica() {
                Id = 105,
                Título = "Timeless (with Playboi Carti)",
                Compositores = "Abel Tesfaye, Blessed, Devon Chisolm (Lawson), Jarrod Morgan, Jordan Terrell Carter, Kobe Hood, Mark Williams (Oji), MIKE DEAN, Pharrell Williams, Raul Cubina (Volta) e Tariq Sharrieff",
                Duracao = TimeSpan.Parse ("4:16"),
        Spotify = "https://open.spotify.com/intl-pt/track/1Es7AUAhQvapIcoh3qMKDL?si=880329414f5e4c39",
        AppleMusic = "https://music.apple.com/br/album/timeless-single/1770380869",
        Youtube = "https://music.youtube.com/watch?v=JpOgr4s3GrE&si=_ZvEAyaAQGwdQ-90"
            },
            new Musica() {
                Id = 106,
                Título = "360",
                Compositores = "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Finn Keane, Henry Walter e Omer Fedi",
                Duracao = TimeSpan.Parse ("2:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/4w2GLmK2wnioVnb5CPQeex?si=304419c971634e60 ",
        AppleMusic = "https://music.apple.com/br/album/360/1739079974?i=1739079976",
        Youtube = "https://music.youtube.com/watch?v=nI6GP8wKJ6o&si=ge1eCroEQEv4gDlL"
            },
            new Musica() {
                Id = 107,
                Título = "Club classics",
                Compositores = "A.G.Cook, Charlotte Aitchison e George Daniel",
                Duracao = TimeSpan.Parse ("2:33"),
        Spotify = "https://open.spotify.com/intl-pt/track/0CySZwyRJ0vyUqtSjM9i2k?si=c47c9971ed94424c",
        AppleMusic = "https://music.apple.com/br/album/club-classics/1739079974?i=1739080339",
        Youtube = "https://music.youtube.com/watch?v=bg9EmWTRt3Y&si=KLHrSIaMskTlI9zT"
            },
            new Musica() {
                Id = 108,
                Título = "Sympathy is a knife",
                Compositores = "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("2:31"),
        Spotify = "https://open.spotify.com/intl-pt/track/5c9tBmJKbTdn1vhzXHeAwW?si=ada15865e96a4196",
        AppleMusic = "https://music.apple.com/br/album/sympathy-is-a-knife/1739079974?i=1739080343",
        Youtube = "https://music.youtube.com/watch?v=EFdiM0f2FWE&si=nZliM-HO_1iJS92V"
            },
            new Musica() {
                Id = 109,
                Título = "I might isay something stupid",
                Compositores = "Charlotte Aitchison e Mike Levy",
                Duracao = TimeSpan.Parse ("1:49"),
        Spotify = "https://open.spotify.com/intl-pt/track/0PFZCt7UNmpas24HejQGu8?si=1971006689074161",
        AppleMusic = "https://music.apple.com/br/album/i-might-say-something-stupid/1739079974?i=1739080345",
        Youtube = "https://music.youtube.com/watch?v=TD2j1OuHoik&si=AV-16SwXdgQugKVz"
            },
            new Musica() {
                Id = 110,
                Título = "Talk talk",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard",
                Duracao = TimeSpan.Parse ("2:41"),
        Spotify = "https://open.spotify.com/intl-pt/track/62fqMvguJbsSs9HKhhRfuS?si=9c0182c60f9343af",
        AppleMusic = "https://music.apple.com/br/album/talk-talk/1739079974?i=1739080348",
        Youtube = "https://music.youtube.com/watch?v=pIs46LzZUws&si=h6eQ04HjF07lfvdY"
            },
            new Musica() {
                Id = 111,
                Título = "Von dutch",
                Compositores = "Charlotte Aitchison e Finn Keane",
                Duracao = TimeSpan.Parse ("2:44"),
        Spotify = "https://open.spotify.com/intl-pt/track/3Y1EvIgEVw51XtgNEgpz5c?si=f5410f920d4b4102",
        AppleMusic = "https://music.apple.com/br/album/von-dutch/1739079974?i=1739080354",
        Youtube = "https://music.youtube.com/watch?v=cwZ1L_0QLjw&si=qOEkJQwF_KG1FYZk"
            },
            new Musica() {
                Id = 112,
                Título = "Everything is romantic",
                Compositores = "A.G.Cook, Charlotte Aitchison, Jasper Harris, Jae Deal, Marlon Travis Barrow e Pablo Diaz-Reixa",
                Duracao = TimeSpan.Parse ("3:23"),
        Spotify = "https://open.spotify.com/intl-pt/track/5sMEEjviCkH6Rp5X2ZvIIc?si=61fdf4b6b61548cc",
        AppleMusic = "https://music.apple.com/br/album/everything-is-romantic/1739079974?i=1739080358",
        Youtube = "https://music.youtube.com/watch?v=FTIvFD7TCVg&si=KTAEgxCSbkVMI3W6"
            },
            new Musica() {
                Id = 113,
                Título = "Rewind",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, e Henry Walter",
                Duracao = TimeSpan.Parse ("2:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/50GxvQA2KEWNt31EdwIlzY?si=2059e6a0bdea47b5",
        AppleMusic = "https://music.apple.com/br/album/rewind/1739079974?i=1739080366",
        Youtube = "https://music.youtube.com/watch?v=WlM7nm3TLnY&si=N2OMJ-ZdPZGmgifB"
            },
            new Musica() {
                Id = 114,
                Título = "So I",
                Compositores = "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("3:31"),
        Spotify = "https://open.spotify.com/intl-pt/track/0AkiAfilrTUXV49dleC5SB?si=fe4deb019dc941b9",
        AppleMusic = "https://music.apple.com/br/album/so-i/1739079974?i=1739080637",
        Youtube = "https://music.youtube.com/watch?v=r9k1CR4LBjk&si=TyR8oMOXtDo2vg1J"
            },
            new Musica() {
                Id = 115,
                Título = "Girl, so confusing",
                Compositores = "Alexander Guy Cook e Charlotte Aitchison",
                Duracao = TimeSpan.Parse ("2:54"),
        Spotify = "https://open.spotify.com/intl-pt/track/41krZZovstMJKeJZJtbL78?si=5dd90ceb33284137",
        AppleMusic = "https://music.apple.com/br/album/girl-so-confusing/1739079974?i=1739080642",
        Youtube = "https://music.youtube.com/watch?v=QXKvjyoH5lM&si=iO9eEHkRUTsGocNk"
            },
            new Musica() {
                Id = 116,
                Título = "Apple",
                Compositores = "Charlotte Aitchison, Linus Wiklund, Noonie Bao e George",
                Duracao = TimeSpan.Parse ("2:31"),
        Spotify = "https://open.spotify.com/intl-pt/track/19RybK6XDbAVpcdxSbZL1o?si=872e3df52a854914",
        AppleMusic = "https://music.apple.com/br/album/apple/1739079974?i=1739080645",
        Youtube = "https://music.youtube.com/watch?v=CPWxExGk7PM&si=bLpquEdjse8ivk_3"
            },
            new Musica() {
                Id = 117,
                Título = "B2b",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, Omer Fedi e Mike Levy",
                Duracao = TimeSpan.Parse ("2:58"),
        Spotify = "https://open.spotify.com/intl-pt/track/4wTvw1dBiPXNiHTh0zzpcI?si=b793d2254c6542a7",
        AppleMusic = "https://music.apple.com/br/album/b2b/1739079974?i=1739080650",
        Youtube = "https://music.youtube.com/watch?v=If4-ckGcr0c&si=bK1QagE7EYx9Rcx4"
            },
            new Musica() {
                Id = 118,
                Título = "Mean girls",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard",
                Duracao = TimeSpan.Parse ("3:09"),
        Spotify = "https://open.spotify.com/intl-pt/track/1qKCO2Tocwg8CbepJ9uDtd?si=badd5edde12f4db5",
        AppleMusic = "https://music.apple.com/br/album/mean-girls/1739079974?i=1739080652",
        Youtube = "https://music.youtube.com/watch?v=IKUQDMEBXN0&si=A_DCSuIiYNpM-p-A"
            },
            new Musica() {
                Id = 119,
                Título = "I think about it all the time",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("2:15"),
        Spotify = "https://open.spotify.com/intl-pt/track/3OaFGqHUyxGVkOcSILw8Kx?si=f58dd756b3154952",
        AppleMusic = "https://music.apple.com/br/album/i-think-about-it-all-the-time/1739079974?i=1739080653",
        Youtube = "https://music.youtube.com/watch?v=Mn0aho8Ayfk&si=V-fdhPAxEUZ9YhPh"
            },
            new Musica() {
                Id = 120,
                Título = "365",
                Compositores = "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Cirkut, Finn Keane (EasyFun) e Omer Fedi",
                Duracao = TimeSpan.Parse ("3:23"),
        Spotify = "https://open.spotify.com/intl-pt/track/5h68SoVFGleijCtjEja3xG?si=2c866d204c6e466a",
        AppleMusic = "https://music.apple.com/br/album/365/1739079974?i=1739080656",
        Youtube = "https://music.youtube.com/watch?v=Ol9CCM240Ag&si=XgTSu7paaDBFS2gK"
            },
            new Musica() {
                Id = 121,
                Título = "The Emptiness Machine",
                Compositores = "Linkin Park",
                Duracao = TimeSpan.Parse ("3:10"),
        Spotify = "https://open.spotify.com/intl-pt/track/2PnlsTsOTLE5jnBnNe2K0A?si=4e0b25da6b25415b",
        AppleMusic = "https://music.apple.com/br/album/the-emptiness-machine/1766137049?i=1766137051",
        Youtube = "https://music.youtube.com/watch?v=KBV_zpMm_0Q&si=amcNs3gO9fxshGrO"
            },
            new Musica() {
                Id = 122,
                Título = "MILLION DOLLAR BABY",
                Compositores = "Ava La'RaeTommy Richman",
                Duracao = TimeSpan.Parse ("2:35"),
        Spotify = "https://open.spotify.com/intl-pt/track/5AJ9hqTS2wcFQCELCFRO7A?si=b3438597a14a49e9",
        AppleMusic = "https://music.apple.com/br/album/million-dollar-baby/1749616853?i=1749616863",
        Youtube = "https://music.youtube.com/watch?v=LF2LGaCsMbc&si=Jhw2LoK82XEMCbEX"
            },
            new Musica() {
                Id = 123,
                Título = "Feelslikeimfallinginlove",
                Compositores = "Max Martin, Apple Martin, Chris Martin, Guy Berryman, Jon Hopkins, Jonny Buckland, Oscar Holter, Tim Rutili e Will Champion",
                Duracao = TimeSpan.Parse ("3:57"),
        Spotify = "https://open.spotify.com/intl-pt/track/49S3znqBAQyPyMpEuKeyJ6?si=875946f59e014c90",
        AppleMusic = "https://music.apple.com/br/album/feelslikeimfallinginlove/1751728791?i=1751728802",
        Youtube = "https://music.youtube.com/watch?v=mG5jXd3MlE0&si=yMwWYbEQLsCfMoIk"
            },
            new Musica() {
                Id = 124,
                Título = "Intro (end of the world)",
                Compositores = "Ariana Grande, Nick Lee, Shintaro Yasuda e Aaron Cheung",
                Duracao = TimeSpan.Parse ("1:32"),
        Spotify = "https://open.spotify.com/intl-pt/track/2o1pb13quMReXZqE7jWsgq?si=4374e14482564ae2",
        AppleMusic = "https://music.apple.com/br/album/intro-end-of-the-world/1725877944?i=1725877946",
        Youtube = "https://music.youtube.com/watch?v=p7jATa6Soag&si=D7-rTk3pplkgsRqt"
            },
            new Musica() {
                Id = 125,
                Título = "bye",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("2:44"),
        Spotify = "https://open.spotify.com/intl-pt/track/1Rweq7vNjK4kZBbGrmxQsl?si=b19329ca14c74f2c",
        AppleMusic = "https://music.apple.com/br/album/bye/1725877944?i=1725877947",
        Youtube = "https://music.youtube.com/watch?v=PlaiDnJyabE&si=64c5X_3TLskiFmXw"
            },
            new Musica() {
                Id = 126,
                Título = "don't wanna break up again",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("2:54"),
        Spotify = "https://open.spotify.com/intl-pt/track/0o3ua5ufFK7nfRzbDUNoGA?si=fe78b91da3024d30",
        AppleMusic = "https://music.apple.com/br/album/dont-wanna-break-up-again/1725877944?i=1725877948",
        Youtube = "https://music.youtube.com/watch?v=_ZSuyl3BZHY&si=YQt6HGyMNVi2tktS"
            },
            new Musica() {
                Id = 127,
                Título = "Saturn Returns Interlude",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("0:42"),
        Spotify = "https://open.spotify.com/intl-pt/track/13jRSCLoWbCoU1XEdJRbgn?si=c8def65641074f94",
        AppleMusic = "https://music.apple.com/br/album/saturn-returns-interlude/1725877944?i=1725877958",
        Youtube = "https://music.youtube.com/watch?v=f68Og1FPFfw&si=d4LPkT0E2_h-wWmN"
            },
            new Musica() {
                Id = 128,
                Título = "eternal sunshine",
                Compositores = "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior",
                Duracao = TimeSpan.Parse ("3:30"),
        Spotify = "https://open.spotify.com/intl-pt/track/3RwWW7KeVhHGayYJgUL5eZ?si=32acb57d292f4bc8",
        AppleMusic = "https://music.apple.com/br/album/eternal-sunshine/1725877944?i=1725877964",
        Youtube = "https://music.youtube.com/watch?v=dS_HLHozs1E&si=t9lFD0pCSviunMeB"
            },
            new Musica() {
                Id = 129,
                Título = "supernatural",
                Compositores = "Ariana Grande, Max Martin e Oscar Görres",
                Duracao = TimeSpan.Parse ("2:43"),
        Spotify = "https://open.spotify.com/intl-pt/track/142PiXzA84lmEw2RstFHFa?si=b0945fa7a0244d9a",
        AppleMusic = "https://music.apple.com/br/album/supernatural/1725877944?i=1725877965",
        Youtube = "https://music.youtube.com/watch?v=4bwnO0FQp1s&si=pJgDjA2-b1lg4HIS"
            },
            new Musica() {
                Id = 130,
                Título = "true story",
                Compositores = "Ariana Grande e Max Martin",
                Duracao = TimeSpan.Parse ("2:43"),
        Spotify = "https://open.spotify.com/intl-pt/track/14kyXBpg91RVq8bNRDS1q2?si=e33bfabbd7d1460b",
        AppleMusic = "https://music.apple.com/br/album/true-story/1725877944?i=1725878238",
        Youtube = "https://music.youtube.com/watch?v=sZTugkGSxSg&si=HCSx7OUHLBnD__XQ"
            },
            new Musica() {
                Id = 131,
                Título = "the boy is mine",
                Compositores = "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior",
                Duracao = TimeSpan.Parse ("2:53"),
        Spotify = "https://open.spotify.com/intl-pt/track/0Lmbke3KNVFXtoH2mMSHCw?si=8fc0516c3e8546ed",
        AppleMusic = "https://music.apple.com/br/album/the-boy-is-mine/1725877944?i=1725878239",
        Youtube = "https://music.youtube.com/watch?v=KwRxeZ9Ro24&si=sjrN78C-uv1Kac_s"
            },
            new Musica() {
                Id = 132,
                Título = "yes, and?",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("3:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/5D34wRmbFS29AjtTOP2QJe?si=b7294dfd89fa42d5",
        AppleMusic = "https://music.apple.com/br/album/yes-and/1725877944?i=1725878240",
        Youtube = "https://music.youtube.com/watch?v=eB6txyhHFG4&si=AtSKx75D9cXOtKvd"
            },
            new Musica() {
                Id = 133,
                Título = "we can't be friends (wait for your love)",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("3:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/51ZQ1vr10ffzbwIjDCwqm4?si=8e3431c973bc49d7",
        AppleMusic = "https://music.apple.com/br/album/we-cant-be-friends-wait-for-your-love/1725877944?i=1725878242",
        Youtube = "https://music.youtube.com/watch?v=KNtJGQkC-WI&si=_XZcfDVk2eNPknZe"
            },
            new Musica() {
                Id = 134,
                Título = "i wish i hated you",
                Compositores = "Ariana Grande e LLya Salamanzadeh",
                Duracao = TimeSpan.Parse ("2:33"),
        Spotify = "https://open.spotify.com/intl-pt/track/5cQX9BexkPIEESTZijJhXg?si=f26b2bc6b2b94dc4",
        AppleMusic = "https://music.apple.com/br/album/i-wish-i-hated-you/1725877944?i=1725878245",
        Youtube = "https://music.youtube.com/watch?v=T5k2-0yRzKc&si=arzgZRNiUA-v-H2x"
            },
            new Musica() {
                Id = 135,
                Título = "imperfect for you",
                Compositores = "Ariana Grande, LLya Salamanzadeh, Max Martin e Peter Kahm",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/6XXKB32Om6WuXg3uEWwTob?si=ab7add9bcfd646ff",
        AppleMusic = "https://music.apple.com/br/album/imperfect-for-you/1725877944?i=1725878247",
        Youtube = "https://music.youtube.com/watch?v=VtQorLzzbQw&si=Ae7IxhrhTw2LJLzP"
            },
            new Musica() {
                Id = 136,
                Título = "ordinary things (feat. Nonna)",
                Compositores = "Ariana Grande, Nick Lee, Luka Kloser e Nonna",
                Duracao = TimeSpan.Parse ("2:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/4mHM5d2fK3n8xgymjf92w2?si=a1bf604ddb3f4a88",
        AppleMusic = "https://music.apple.com/br/album/ordinary-things-feat-nonna/1725877944?i=1725878248",
        Youtube = "https://music.youtube.com/watch?v=6XWMiMlZHfA&si=fcUbIQgEq8Fc2OZp"
            },
            new Musica() {
                Id = 137,
                Título = "STARS",
                Compositores = "Lucien Parker,Barringington D. Hendricks, Billy Ray Schlag, Darhyl Camper Jr., Isaac De Boni, Michael Mule, Quentin Miller, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("1:55"),
        Spotify = "https://open.spotify.com/intl-pt/track/1LaTWJ35Atk7Esoqxdb1WG?si=22fb62a7df514fcf",
        AppleMusic = "https://music.apple.com/br/album/stars/1732096585?i=1732096589",
        Youtube = "https://music.youtube.com/watch?v=j1BkA7KXV3c&si=QJcF30jQGeFCxvL2"
            },
            new Musica() {
                Id = 138,
                Título = "KEYS TO MY LIFE",
                Compositores = "Cydel C. Young, Hubert E. Polinski, Konrad Żyrek, Samuel C. Lindley, Tim Mosley, Ty Dolla $ign, Veyis-Can Urun, Vincent Vendi e Ye",
                Duracao = TimeSpan.Parse ("2:54"),
        Spotify = "https://open.spotify.com/intl-pt/track/7oPlYYNWDSEQRDb978Bhhc?si=e3c4597993e34afc",
        AppleMusic = "https://music.apple.com/br/album/keys-to-my-life/1732096585?i=1732096602",
        Youtube = "https://music.youtube.com/watch?v=kX3ivxNp9PY&si=p94mtlap1V6mQ5iP"
            },
            new Musica() {
                Id = 139,
                Título = "PAID",
                Compositores = "Chrishan, Anthony Kilhoffer, Cedric R Hailey, Christopher C. Dotson, Hamid Bashir, Louis K. Celestin, Samuel C. LindleyTyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:15"),
        Spotify = "https://open.spotify.com/intl-pt/track/2uK5bMcng3sT2tv0BOyhCt?si=5040bbb44a494ae9",
        AppleMusic = "https://music.apple.com/br/album/paid/1732096585?i=1732096927",
        Youtube = "https://music.youtube.com/watch?v=oG1xb5KOcN4&si=Gu8HzGL7e6x1kEdi"
            },
            new Musica() {
                Id = 140,
                Título = "TALKING",
                Compositores = "Anthony Clemons Jr, Darhyl Camper Jr., Dominic Maker, Edward Davadi, James B. Litherland, Kasseem D. Dean, North West, Quentin Miller, Shawntoni A. Nichols, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:05"),
        Spotify = "https://open.spotify.com/intl-pt/track/3cPz4AkNOXwDf4DlWmKmIE?si=2b7231910abd41fa",
        AppleMusic = "https://music.apple.com/br/album/talking/1732096585?i=1732097210",
        Youtube = "https://music.youtube.com/watch?v=Tqlw87XV4kU&si=4nHKH-sRJ1Yj7WpJ"
            },
            new Musica() {
                Id = 141,
                Título = "BACK TO ME",
                Compositores = "Aswad Asif, Charles M. Njapa, Daniel Kin J. Chien, Frederick Tipton, James A. Hau, Nicholas M. Balding, Sasha Hashemi, Tyrone Griffin, Jr., Ye e Zachary R. Frenes",
                Duracao = TimeSpan.Parse ("4:55"),
        Spotify = "https://open.spotify.com/intl-pt/track/5d4XWuMLbTuPMTPaMYA0VG?si=c6068e0319cb4707",
        AppleMusic = "https://music.apple.com/br/album/back-to-me/1732096585?i=1732097229",
        Youtube = "https://music.youtube.com/watch?v=MiTIhSb-b2k&si=e1E4kHtSU2bHKGnY"
            },
            new Musica() {
                Id = 142,
                Título = "HOODRAT",
                Compositores = "Charles M. Njapa, Darhyl Camper Jr., Malik Y. Jones, Robert G. Booker, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:42"),
        Spotify = "https://open.spotify.com/intl-pt/track/5FlpNdFCZfcrtV6HcAg9Rx?si=14d61eb84b0b43fe",
        AppleMusic = "https://music.apple.com/br/album/hoodrat/1732096585?i=1732097780",
        Youtube = "https://music.youtube.com/watch?v=eHHwQMxvVOU&si=nHNRhYPjcsBzLxqy"
            },
            new Musica() {
                Id = 143,
                Título = "DO IT",
                Compositores = "Chrishan, Alexander West, Billy Ray Schlag, Darhyl Camper Jr., Denis Raab, Dijon I. McFarlane, Ermias J. Asghedom, Keenon Dequan R. Jackson, Kevin Gomringer, Lukas Benjamin Leth Kroll, Samuel C. Lindley, Supreme Williams, Tim Gomringer, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:45"),
        Spotify = "https://open.spotify.com/intl-pt/track/5iroQL70VoSFrC8ZhVnskA?si=91b801d494d442aa",
        AppleMusic = "https://music.apple.com/br/album/do-it/1732096585?i=1732097972",
        Youtube = "https://music.youtube.com/watch?v=G0hxhn7-Hps&si=UFaZzy6f_DaoiE6Q"
            },
            new Musica() {
                Id = 144,
                Título = "PAPERWORK",
                Compositores = "ADERLI RAMIREZ OVIEDO, Bruno Gioia Martins Funke Da Costa, Charles M. Njapa, Kasseem D. Dean, Leonardo Felipe Yasmil Garces, Nasir H. Pemberton, Quavious Keyate Marshall, Samuel C. Lindley, Ty Dolla $ign, Tyrone Griffin, Jr. e Victor Hugo Maciel dos Santos",
                Duracao = TimeSpan.Parse ("2:25"),
        Spotify = "https://open.spotify.com/intl-pt/track/4QrJxzBxuIWWW0NxA6FRNF?si=8571179049d74e0e",
        AppleMusic = "https://music.apple.com/br/album/paperwork/1732096585?i=1732098149",
        Youtube = "https://music.youtube.com/watch?v=FmrXYkfv2eU&si=5_ooPr4toBJ08ccl"
            },
            new Musica() {
                Id = 145,
                Título = "BURN",
                Compositores = "Amir Stivie B, Christopher C. Dotson, John Beck, Joseph Goddard, Leon Thomas, Morten Ristorp, Samuel C. Lindley, Tyrone Griffin, Jr., Tyshane Thompson, Valentina Pappalardo e Ye",
                Duracao = TimeSpan.Parse ("1:51"),
        Spotify = "https://open.spotify.com/intl-pt/track/38BgRP0EX5p0sBj0fFhqN9?si=7e91c8bbcfad4f75",
        AppleMusic = "https://music.apple.com/br/album/burn/1732096585?i=1732098274",
        Youtube = "https://music.youtube.com/watch?v=oAbX14IadBo&si=HnrVjugcjbur-Fuz"
            },
            new Musica() {
                Id = 146,
                Título = "FUK SUMN",
                Compositores = "Chrishan, Barringington D. Hendricks, Christopher C. Dotson, Evan K. Hood-Atlas, Jacques B. Webster II, Jordan T. Carter, Quavious Keyate Marshall, Quentin Miller, Samuel C. Lindley, Tim Mosley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:29"),
        Spotify = "https://open.spotify.com/intl-pt/track/4eIYnlcgI2chjQBuW1VRr7?si=ec536947ed2e47f7",
        AppleMusic = "https://music.apple.com/br/album/fuk-sumn/1732096585?i=1732098446",
        Youtube = "https://music.youtube.com/watch?v=xd2SEKy6HIM&si=eRW1RTw63Vfc59WL"
            },
            new Musica() {
                Id = 147,
                Título = "VULTURES",
                Compositores = "Jasper Harris, Mark Williams, Cydel C. Young, Durk D. Banks, Gustave Rudman Rambali, Jason T. Harris, Jordan Houston, Marlon T. Barrow, Mathias D. Liyew, Paul Beauregard, Pharris Thomas, Raul I. Cubina, Terrace M. Boykin, Tyrone Griffin, Jr. e Ye ",
                Duracao = TimeSpan.Parse ("4:36"),
        Spotify = "https://open.spotify.com/intl-pt/track/0Cz12ejDQ5L1c1f4sVck4n?si=796bf14c24014f42",
        AppleMusic = "https://music.apple.com/br/album/vultures/1732096585?i=1732098460",
        Youtube = "https://music.youtube.com/watch?v=kCMz7HW6O-g&si=q2HirAxnrr2i8hus"
            },
            new Musica() {
                Id = 148,
                Título = "CARNIVAL",
                Compositores = "Mark Williams, Raul Cubina(of Ojivolta), Dimitri Rogers, Grant Dickinson, Jordan T. Carter, Raul I. Cubina, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("4:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/4OssqCixV2Xsxd43wMIQyS?si=ae9a6ec5cef04764",
        AppleMusic = "https://music.apple.com/br/album/carnival-feat-playboi-carti/1732096585?i=1732098695",
        Youtube = "https://music.youtube.com/watch?v=pEskP0ulPlA&si=YAVfefsckULF308S"
            },
            new Musica() {
                Id = 149,
                Título = "BEG FORGIVENESS",
                Compositores = "Barrington D. Hendricks, Faouzia Ouihya, John Beck, Joseph Goddard, Latia T. Lindley, London T. Holmes, Quentin Miller, Tyrone Griffin, Jr., Valentina Pappalardo e Ye",
                Duracao = TimeSpan.Parse ("6:08"),
        Spotify = "https://open.spotify.com/intl-pt/track/6hMzSNx3vrFu3y27lnEDWE?si=1b0247569f434bf2",
        AppleMusic = "https://music.apple.com/br/album/beg-forgiveness/1732096585?i=1732098706",
        Youtube = "https://music.youtube.com/watch?v=EXmMiBNDVz4&si=EBT-1QiZlBCbDIVS"
            },
            new Musica() {
                Id = 150,
                Título = "PROBLEMATIC",
                Compositores = "Camper, Amber D. Streeter, Charles E. Hugo, Charles M. Njapa, Denzel A. Charles, Melvin Moore, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:14"),
        Spotify = "https://open.spotify.com/intl-pt/track/1zO4yPBdlaRSLko5BY33od?si=4c4af39dfa5848da",
        AppleMusic = "https://music.apple.com/br/album/problematic/1732096585?i=1732099023",
        Youtube = "https://music.youtube.com/watch?v=xcprkHw4cd8&si=QeRtrihJH0YqNE1p"
            },
            new Musica() {
                Id = 151,
                Título = "KING",
                Compositores = "Arturo Fratini, Barringington D. Hendricks, Charles M. Njapa, Dylan T. Cleary-Krell, Frederick Tipton, Tyrone Griffin, Jr., Victor Mensah e Ye",
                Duracao = TimeSpan.Parse ("2:36"),
        Spotify = "https://open.spotify.com/intl-pt/track/3nmtzobpqStsxsfRNykwFC?si=e0db7d8749f544b4",
        AppleMusic = "https://music.apple.com/br/album/king/1732096585?i=1732099368",
        Youtube = "https://music.youtube.com/watch?v=g6vAQpxo35g&si=u8HDaW3Z1EISRbdK"
            },
            new Musica() {
                Id = 152,
                Título = "THE BOX MEDLEY FUNK 2",
                Compositores = "Mc Brinquedo, MC Cebezinho, Mc Laranjinha e MC Tuto",
                Duracao = TimeSpan.Parse ("4:26"),
        Spotify = "https://open.spotify.com/intl-pt/track/7IFsTX5H1sWcEl8joV0IdD?si=dbd352ce7f3749c8",
        AppleMusic = "https://music.apple.com/br/album/the-box-medley-funk-2/1740221242?i=1740221258",
        Youtube = "https://music.youtube.com/watch?v=ZRcA5aH0Wto&si=XYJ0RcMHdJ5Oq349"
            },
            new Musica() {
                Id = 153,
                Título = "Psycho CEO",
                Compositores = "Abdul Moiz, George Kala, Michael Ojha e Noah Smith",
                Duracao = TimeSpan.Parse ("3:45"),
        Spotify = "https://open.spotify.com/intl-pt/track/2dyAiC9k6s0mWnMSQRQJGd?si=a33dec0a4fdb47b9",
        AppleMusic = "https://music.apple.com/br/album/psycho-ceo/1731490449?i=1731490455",
        Youtube = "https://music.youtube.com/watch?v=mJgpzJpodk8&si=dW6JlWC8E1vtMCdf"
            },
            new Musica() {
                Id = 154,
                Título = "Power Trip",
                Compositores = "Aaron Shadrow, Jasper Harris, Tom Levesque, Anton Martin Mendo, Arman Andican, Donald Glover, Noah Smith, Oscar Adler e Thomas Levesque",
                Duracao = TimeSpan.Parse ("4:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/3bDH7eIQ84QWdBeWwffUZD?si=38916b289c4a4e79",
        AppleMusic = "https://music.apple.com/br/album/power-trip/1731490449?i=1731490456",
        Youtube = "https://music.youtube.com/watch?v=cVEa5o9W77U&si=MJPG1QO23kl-BxXs"
            },
            new Musica() {
                Id = 155,
                Título = "Breathe",
                Compositores = "Anton Martin Mendo, Bart van Hoewijk e Noah Smith",
                Duracao = TimeSpan.Parse ("2:50"),
        Spotify = "https://open.spotify.com/intl-pt/track/5NAOhPAZ57eFAXr3qatS6i?si=6968dbda934c483c",
        AppleMusic = "https://music.apple.com/br/album/breathe/1731490449?i=1731490577",
        Youtube = "https://music.youtube.com/watch?v=zWaVz9m3S_k&si=0eCNdWEqgIezqEQt"
            },
            new Musica() {
                Id = 156,
                Título = "Morë",
                Compositores = "Daniel Pérez, Javier Mercado e Noah Smith",
                Duracao = TimeSpan.Parse ("2:45"),
        Spotify = "https://open.spotify.com/intl-pt/track/7KdQOqCspznOjPDT0KAnuq?si=2f132730a72b439f",
        AppleMusic = "https://music.apple.com/br/album/mor%C3%AB/1731490449?i=1731490578",
        Youtube = "https://music.youtube.com/watch?v=L4U1ByXfHGo&si=uxTZP653wwf88Q4Q"
            },
            new Musica() {
                Id = 157,
                Título = "Bought The Earth",
                Compositores = "Aaron Cheung, Carlton McDowell Jr, Charlie Coffeen, Noah Smith e Rex Masamune Kudo",
                Duracao = TimeSpan.Parse ("2:58"),
        Spotify = "https://open.spotify.com/intl-pt/track/5Bno6wFa22tRbFUwh4iZdk?si=ce79ad844f46409d",
        AppleMusic = "https://music.apple.com/br/album/bought-the-earth/1731490449?i=1731490579",
        Youtube = "https://music.youtube.com/watch?v=NuZoznmvo88&si=n6OBRFm2kDEO_3ZW"
            },
            new Musica() {
                Id = 158,
                Título = "Nothing Changë",
                Compositores = "Cooper Coad, George Kala e Noah Smith",
                Duracao = TimeSpan.Parse ("3:57"),
        Spotify = "https://open.spotify.com/intl-pt/track/3rLjenWhYQNFGI1xrvTHWy?si=5757612570db4d7e",
        AppleMusic = "https://music.apple.com/br/album/nothing-chang%C3%AB/1731490449?i=1731490583",
        Youtube = "https://music.youtube.com/watch?v=8yTPJ15dSz4&si=MEoIvCkHC2VRXDww"
            },
            new Musica() {
                Id = 159,
                Título = "U Should Know",
                Compositores = "Abdul Moiz, Neile Ode e Noah Smith",
                Duracao = TimeSpan.Parse ("3:06"),
        Spotify = "https://open.spotify.com/intl-pt/track/17vVm6v7GE2tP2KRVbCwqv?si=d72f7dc05c744298",
        AppleMusic = "https://music.apple.com/br/album/u-should-know/1731490449?i=1731490590",
        Youtube = "https://music.youtube.com/watch?v=H9lmz6dFhi8&si=5UAQHEEhdp4mM_Mt"
            },
            new Musica() {
                Id = 160,
                Título = "Lyfestylë (with Lil Wayne)",
                Compositores = "Javier Mercado, Joey Fenderson, Noah Smith e Salah Nizami",
                Duracao = TimeSpan.Parse ("3:56"),
        Spotify = "https://open.spotify.com/intl-pt/track/15qRV1yUqFR6ViOwxoopod?si=137f05bf6d624d5d",
        AppleMusic = "https://music.apple.com/br/album/lyfestyl%C3%AB/1731490449?i=1731490593",
        Youtube = "https://music.youtube.com/watch?v=uRWvjctfhqo&si=G-yHsv0XOmd52OxF"
            },
            new Musica() {
                Id = 161,
                Título = "ILUV",
                Compositores = "Edith Frances, Ethan Kath, Javier Mercado, Noah Smith e Rio Leyva",
                Duracao = TimeSpan.Parse ("3:03"),
        Spotify = "https://open.spotify.com/intl-pt/track/30ln1OwxEZdXDfEploBcsU?si=f40ff35e01d840af",
        AppleMusic = "https://music.apple.com/br/album/iluv/1731490449?i=1731490594",
        Youtube = "https://music.youtube.com/watch?v=dMC9SZH-HrU&si=x8F9uqNqAutOMuuB"
            },
            new Musica() {
                Id = 162,
                Título = "Tell më",
                Compositores = "Cyrus Spurlock, Gabriel St-Onge, Javier Mercado, Louis Esposito, Noah Smith e Spencer Mott",
                Duracao = TimeSpan.Parse ("4:03"),
        Spotify = "https://open.spotify.com/intl-pt/track/1ObrUCFugAMJoXcvpggbOd?si=862ba6ef4208451d",
        AppleMusic = "https://music.apple.com/br/album/tell-m%C3%AB/1731490449?i=1731490595",
        Youtube = "https://music.youtube.com/watch?v=f8JEilGmNUM&si=B6MFteNQJVKnwIAV"
            },
            new Musica() {
                Id = 163,
                Título = "Shade",
                Compositores = "Christian Boggs, Daniel Mohammadi, Francesca Boszormenyi, Javier Mercado, Joy Evangeline Moreno, Louis Esposito, Nathan Andrew Chen e Noah Smith",
                Duracao = TimeSpan.Parse ("4:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/3vpocwyn0RvKzeXo1tzSrW?si=e06f5884a0d04800",
        AppleMusic = "https://music.apple.com/br/album/shade/1731490449?i=1731490596",
        Youtube = "https://music.youtube.com/watch?v=1sXnH2l0Pfw&si=e7zB9G7QEa-6T6Ap"
            },
            new Musica() {
                Id = 164,
                Título = "Keep Pushin",
                Compositores = "Abdul Moiz, Anton Martin Mendo, Neile Ode, Noah Smith e Tobias Dekker",
                Duracao = TimeSpan.Parse ("2:46"),
        Spotify = "https://open.spotify.com/intl-pt/track/49wkg1xBo56T3oSa778RWA?si=1bc0195014784d15",
        AppleMusic = "https://music.apple.com/br/album/keep-pushin/1731490449?i=1731490601",
        Youtube = "https://music.youtube.com/watch?v=biHsQTXavBs&si=hnCsp_xZ0J5cCn5l"
            },
            new Musica() {
                Id = 165,
                Título = "Riot & Set it off",
                Compositores = "Anton Martin Mendo, Clint Mansell e Noah Smith",
                Duracao = TimeSpan.Parse ("2:38"),
        Spotify = "https://open.spotify.com/intl-pt/track/2qzkFJtbIFrGpOctOBeCbi?si=7bfbe9843ffc4635",
        AppleMusic = "https://music.apple.com/br/album/riot-set-it-off/1731490449?i=1731490602",
        Youtube = "https://music.youtube.com/watch?v=n28xgaiXy8g&si=2dUBlYuTVUesOyPc"
            },
            new Musica() {
                Id = 166,
                Título = "Team ceo",
                Compositores = "Anton Martin Mendo, Noah Smith, Sam Lawalata e Tobias Dekker",
                Duracao = TimeSpan.Parse ("3:17"),
        Spotify = "https://open.spotify.com/intl-pt/track/0D01toUYF9V47nYuzov5BZ?si=ded582ea7a8e492e",
        AppleMusic = "https://music.apple.com/br/album/team-ceo/1731490449?i=1731490604",
        Youtube = "https://music.youtube.com/watch?v=2ZGMuOuE6Fc&si=1P_rxXEPbw8uqN-p"
            },
            new Musica() {
                Id = 167,
                Título = "2093",
                Compositores = "Anton Martin Mendo, Arman Andican, Ethan Andrade, Noah Smith e Oscar Adler",
                Duracao = TimeSpan.Parse ("2:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/3si9GTRnTpVGI1UIysHtrC?si=3e91bf8d569441dd",
        AppleMusic = "https://music.apple.com/br/album/2093/1731490449?i=1731490605",
        Youtube = "https://music.youtube.com/watch?v=NNUbwA-oS1c&si=QP7i5E7IimMLwwQ3"
            },
            new Musica() {
                Id = 168,
                Título = "Stand On It (with Future)",
                Compositores = "George Kala, Nayvadius Wilburn e Noah Smith",
                Duracao = TimeSpan.Parse ("3:00"),
        Spotify = "https://open.spotify.com/intl-pt/track/7H3lr9bsPBGFx5NyTuBBGc?si=abf787df56da4bb8",
        AppleMusic = "https://music.apple.com/br/album/stand-on-it/1731490449?i=1731490606",
        Youtube = "https://music.youtube.com/watch?v=Mnw4LnbU8hQ&si=AZRE1iVDjMxcom-C"
            },
            new Musica() {
                Id = 169,
                Título = "Familia",
                Compositores = "Benjamin Saint Fort, Abdul Moiz, Cyrus Spurlock e Noah Smith",
                Duracao = TimeSpan.Parse ("2:34"),
        Spotify = "https://open.spotify.com/intl-pt/track/2OM0MeY7mPIRbs8SCzRdTH?si=2aa77c4e08324b8d",
        AppleMusic = "https://music.apple.com/br/album/familia/1731490449?i=1731490817",
        Youtube = "https://music.youtube.com/watch?v=Ye02TykznWI&si=IGf_wnnVABMWOlyd"
            },
            new Musica() {
                Id = 170,
                Título = "Mr. Inbetweenit",
                Compositores = "Matthew Shalnev, Nikita Zvorygin e Noah Smith",
                Duracao = TimeSpan.Parse ("3:18"),
        Spotify = "https://open.spotify.com/intl-pt/track/0S4xIJdaXd30Y7Lqe5WQws?si=57b812dfa6e246ce",
        AppleMusic = "https://music.apple.com/br/album/mr-inbetweenit/1731490449?i=1731490818",
        Youtube = "https://music.youtube.com/watch?v=e02uqFGuiJA&si=SeiV8lHSsSCfLGql"
            },
            new Musica() {
                Id = 171,
                Título = "Psychocainë",
                Compositores = "Abdul Moiz, Michael Ojha,Noah Smith e Oscar Vidal",
                Duracao = TimeSpan.Parse ("2:46"),
        Spotify = "https://open.spotify.com/intl-pt/track/3xGMKrKN8DdLltEfA17ivN?si=aaba553dd14240c2",
        AppleMusic = "https://music.apple.com/br/album/psychocain%C3%AB/1731490449?i=1731490819",
        Youtube = "https://music.youtube.com/watch?v=VfkDWye904A&si=2MClzoX2YHWIjdQy"
            },
            new Musica() {
                Id = 172,
                Título = "Run Thëy Mouth",
                Compositores = "George Kala, Noah Smith e Oscar Vidal",
                Duracao = TimeSpan.Parse ("3:26"),
        Spotify = "https://open.spotify.com/intl-pt/track/6Y9LODoptY2RDhLJtZXAG7?si=39ca64e7405746c3",
        AppleMusic = "https://music.apple.com/br/album/run-th%C3%ABy-mouth/1731490449?i=1731490820",
        Youtube = "https://music.youtube.com/watch?v=p_sNK5qZir4&si=rNx0i95Bgi2ZYgEi"
            },
            new Musica() {
                Id = 173,
                Título = "If We Being Rëal",
                Compositores = "Eric Kjell Jowett, Gabriel St-Onge, Javier Mercado, Joey Fenderson, Louis Esposito, Noah Smith e Spencer Mott",
                Duracao = TimeSpan.Parse ("2:52"),
        Spotify = "https://open.spotify.com/intl-pt/track/0YThXX1dqUpYBLyJNAsF9N?si=82d0573bfdf649e5",
        AppleMusic = "https://music.apple.com/br/album/if-we-being-r%C3%ABal/1731490449?i=1731490822",
        Youtube = "https://music.youtube.com/watch?v=1xcvWmN0Pe4&si=u4VM7ygf_5nny3_W"
            },
            new Musica() {
                Id = 174,
                Título = "1093",
                Compositores = "Aaron Shadrow, Benjamin Bock, Noah Smith e Rex Masamune Kudo",
                Duracao = TimeSpan.Parse ("2:36"),
        Spotify = "https://open.spotify.com/intl-pt/track/4ueAQTrrK9U3gx1VubzdcD?si=e55b5e7125984074",
        AppleMusic = "https://music.apple.com/br/album/1093/1731490449?i=1731490824",
        Youtube = "https://music.youtube.com/watch?v=Q_YqjsDZRFk&si=_QORzzvSxOzieo1Z"
            },
            new Musica() {
                Id = 175,
                Título = "St. Chroma (feat. Daniel Caesar)",
                Compositores = "Ashton Dumar Simmonds e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:17"),
        Spotify = "https://open.spotify.com/intl-pt/track/1QoyuMHNBe7lg3YW4Qtll4?si=98a8898576d4436a",
        AppleMusic = "https://music.apple.com/br/album/st-chroma-feat-daniel-caesar/1776500452?i=1776500453",
        Youtube = "https://music.youtube.com/watch?v=hCcwCv3G1FQ&si=tXIXoE0u-mQcbmXx"
            },
            new Musica() {
                Id = 176,
                Título = "Rah Tah Tah",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("2:45"),
        Spotify = "https://open.spotify.com/intl-pt/track/5RePVWy39tLpHH0WwXgBsK?si=8e403a9c400f45ba",
        AppleMusic = "https://music.apple.com/br/album/rah-tah-tah/1776500452?i=1776500454",
        Youtube = "https://music.youtube.com/watch?v=R_clisSImS4&si=-fj8lWF5j2_iOiR0"
            },
            new Musica() {
                Id = 177,
                Título = "Noid",
                Compositores = "Paul Dobson Nyirongo e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:44"),
        Spotify = "https://open.spotify.com/intl-pt/track/1YdtGoSYDvVQKoUqSDXX41?si=b896b5f548924285",
        AppleMusic = "https://music.apple.com/br/album/noid/1776500452?i=1776500455",
        Youtube = "https://music.youtube.com/watch?v=Qer3lwd5hyA&si=nsF3qTxgb_lJdqNO"
            },
            new Musica() {
                Id = 178,
                Título = "Darling, I (feat. Teezo Touchdown)",
                Compositores = "Barry White, Kamaal Ibn John Fareed e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/0VaeksJaXy5R1nvcTMh3Xk?si=448d803d41e94079",
        AppleMusic = "https://music.apple.com/br/album/darling-i-feat-teezo-touchdown/1776500452?i=1776500456",
        Youtube = "https://music.youtube.com/watch?v=ZWDoUsxpkKE&si=i7oDOuvRlvho3wZp"
            },
            new Musica() {
                Id = 179,
                Título = "Hey Jane",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:00"),
        Spotify = "https://open.spotify.com/intl-pt/track/3Umj02ZNl4d356pS1D38mn?si=66f86cfd705542ad",
        AppleMusic = "https://music.apple.com/br/album/hey-jane/1776500452?i=1776500457",
        Youtube = "https://music.youtube.com/watch?v=qFfjnPOXmUM&si=FKujOBnHZmq3iH8w"
            },
            new Musica() {
                Id = 180,
                Título = "I Killed You",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("2:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/3GdwjAsCsoE79ObhsJFyYb?si=9c7b1cb2cdc441e2",
        AppleMusic = "https://music.apple.com/br/album/i-killed-you/1776500452?i=1776500458",
        Youtube = "https://music.youtube.com/watch?v=bKTmpKPjJxs&si=9OeobLDbzk27gd10"
            },
            new Musica() {
                Id = 181,
                Título = "Judge Judy",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:29"),
        Spotify = "https://open.spotify.com/intl-pt/track/6ie0uyyvOKTTuIFBMPiNIl?si=29b0e9ffba9a417b",
        AppleMusic = "https://music.apple.com/br/album/judge-judy/1776500452?i=1776500459",
        Youtube = "https://music.youtube.com/watch?v=FQUI8KmRUw0&si=Mf2MHlr6nuqK94N-"
            },
            new Musica() {
                Id = 182,
                Título = "Sticky (feat. GloRilla, Sexyy Red & Lil Wayne)",
                Compositores = "Aaron Bolton, David Darnell Brown, Dudley Alexander Duverne, Dwyane Carter, Jr., Elvis L. Jr. Williams, Gloria Woods, Jamal F Jones, Janae Wherry, Rex Zamor, Tim Mosley, Timothy clayton, Tyler Okonma e Zachary Anson Wallace",
                Duracao = TimeSpan.Parse ("4:15"),
        Spotify = "https://open.spotify.com/intl-pt/track/3tFed7YsjGnIfxeLEQwx3R?si=ee53712adbf347b6",
        AppleMusic = "https://music.apple.com/br/album/sticky-feat-glorilla-sexyy-red-lil-wayne/1776500452?i=1776500460",
        Youtube = "https://music.youtube.com/watch?v=16KSivdIGjQ&si=VzRo3NkIah_-IxS0"
            },
            new Musica() {
                Id = 183,
                Título = "Take Your Mask Off (feat. Daniel Caesar & LaToiya Williams)",
                Compositores = "Greg Cook, K. Thomas e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/4BSR9I4ExlCJdXJo2GpBD5?si=5a9f26477a664f84",
        AppleMusic = "https://music.apple.com/br/album/take-your-mask-off-feat-daniel-caesar-latoiya-williams/1776500452?i=1776500462",
        Youtube = "https://music.youtube.com/watch?v=JPOjiXoPmOk&si=xrxpK24OV7YkNOzj"
            },
            new Musica() {
                Id = 184,
                Título = "Tomorrow",
                Compositores = "Ashton Dumar Simmonds e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:02"),
        Spotify = "https://open.spotify.com/intl-pt/track/3yw3m8wgRB4ptDyAvtdhq5?si=696ce821c3d74e4d",
        AppleMusic = "https://music.apple.com/br/album/tomorrow/1776500452?i=1776500463",
        Youtube = "https://music.youtube.com/watch?v=n2KOgQJbZAw&si=fmns2mOlVSnLhVrW"
            },
            new Musica() {
                Id = 185,
                Título = "Thought I Was Dead (feat. ScHoolboy Q & Santigold)",
                Compositores = "Quincy Hanley e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:27"),
        Spotify = "https://open.spotify.com/intl-pt/track/2aYHxnMF2umAavtgBvmkY1?si=b9d5d0360b694ac9",
        AppleMusic = "https://music.apple.com/br/album/thought-i-was-dead-feat-schoolboy-q-santigold/1776500452?i=1776500464",
        Youtube = "https://music.youtube.com/watch?v=HS1OUFCfFdY&si=jgeUBqL_J94IISxe"
            },
            new Musica() {
                Id = 186,
                Título = "Like Him (feat. Lola Young)",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:38"),
        Spotify = "https://open.spotify.com/intl-pt/track/6jbYpRPTEFl1HFKHk1IC0m?si=b078f08e8ee1437a",
        AppleMusic = "https://music.apple.com/br/album/like-him-feat-lola-young/1776500452?i=1776500465",
        Youtube = "https://music.youtube.com/watch?v=dgUHE8wWhiE&si=onANzdP8S1Zcg8E_"
            },
            new Musica() {
                Id = 187,
                Título = "Balloon (feat. Doechii)",
                Compositores = "Harry Wayne Casey, James Brown, Jaylah Hickmon, Luther Campbell, Rick Finch, Robert Ginyard e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:29"),
        Spotify = "https://open.spotify.com/intl-pt/track/35D1RA5uVFVhMc1qX80TaQ?si=6ad6caa61f5a4b39",
        AppleMusic = "https://music.apple.com/br/album/balloon-feat-doechii/1776500452?i=1776500466",
        Youtube = "https://music.youtube.com/watch?v=eZNxD4NbxLA&si=nyre0TlPAQovIFhh"
            },
            new Musica() {
                Id = 188,
                Título = "Barbie",
                Compositores = "Emerson Teixeira Muniz e Glenner Robert Cândido",
                Duracao = TimeSpan.Parse ("3:12"),
        Spotify = "https://open.spotify.com/intl-pt/track/6s1kzj4EbhFLXbuAGJbhbn?si=8ce7f820135746df",
        AppleMusic = "https://music.apple.com/br/album/barbie/1774463235?i=1774463237",
        Youtube = "https://music.youtube.com/watch?v=4t7au8Tm9xY&si=4JDPe0rNykqFWdqI"
            },
            new Musica() {
                Id = 189,
                Título = "APT.",
                Compositores = "Amy Allen, Bruno Mars, Chae Young Park, Christopher Brody Brown, Henry Walter, Michael Chapman, Nicholas Chinn, Omer Fedi, Philip Lawrence, Rogét Chahayed e Theron Thomas",
                Duracao = TimeSpan.Parse ("2:49"),
        Spotify = "https://open.spotify.com/intl-pt/track/5vNRhkKd0yEAg8suGBpjeY?si=2ac95c59109944e6",
        AppleMusic = "https://music.apple.com/br/album/apt/1773452219?i=1773452221",
        Youtube = "https://music.youtube.com/watch?v=58-AKkNMZNQ&si=h8WaQTEorxCsFRP-"
            },
            new Musica() {
                Id = 190,
                Título = "Sou + Você",
                Compositores = "Caetano Veloso e Mano Brown",
                Duracao = TimeSpan.Parse ("1:48"),
        Spotify = "https://open.spotify.com/intl-pt/track/5G1T3Cj4vP7uiGMUb278ut?si=e3e3f28f397d4787",
        AppleMusic = "https://music.apple.com/br/album/sou-voc%C3%AA/1198317040?i=1198317073",
        Youtube = "https://music.youtube.com/watch?v=TB5gzXCAx7o&si=NoTmImmFRsWvyq3_"
            },
            new Musica() {
                Id = 191,
                Título = "Vivão e Vivendo",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("1:57"),
        Spotify = "https://open.spotify.com/intl-pt/track/2igfCmo0TuciHyKMB8zWrr?si=8e944ca5c4ff45ac",
        AppleMusic = "https://music.apple.com/br/album/viv%C3%A3o-e-vivendo/1198317040?i=1198317074",
        Youtube = "https://music.youtube.com/watch?v=wnkougMAqog&si=blIGPj5ieViMGThx"
            },
            new Musica() {
                Id = 192,
                Título = "Vida Loka (Intro)",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("0:24"),
        Spotify = "https://open.spotify.com/intl-pt/track/7ATfKy3NYMRfK5JZvFQJYX?si=8e69f06f7b1d4a52",
        AppleMusic = "https://music.apple.com/br/album/vida-loka-intro/1198317040?i=1198317075",
        Youtube = "https://music.youtube.com/watch?v=mnhX41tvuUU&si=-XUUKBHYLj8beWkF"
            },
            new Musica() {
                Id = 193,
                Título = "Vida Loka, Pt. 1",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:03"),
        Spotify = "https://open.spotify.com/intl-pt/track/6m8AgjfI28ER6odzMxmHtR?si=04abde4ef81e45c7",
        AppleMusic = "https://music.apple.com/br/album/vida-loka-pt-1/1198317040?i=1198317076",
        Youtube = "https://music.youtube.com/watch?v=IL1epaZCTmk&si=-nw1u-Q6Z5kk1grD"
            },
            new Musica() {
                Id = 194,
                Título = "Negro Drama",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:51"),
        Spotify = "https://open.spotify.com/intl-pt/track/3ytXzEJFeVydFfmUhHvti8?si=49ba04f17c6a44bb",
        AppleMusic = "https://music.apple.com/br/album/negro-drama/1198317040?i=1198317077",
        Youtube = "https://music.youtube.com/watch?v=u4lcUooNNLY&si=RKuecvXNwdW6pJas"
            },
            new Musica() {
                Id = 195,
                Título = "A Vítima",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:20"),
        Spotify = "https://open.spotify.com/intl-pt/track/2ki0ZW9m5HIAdALRldfXM1?si=890dc6add925447d",
        AppleMusic = "https://music.apple.com/br/album/a-v%C3%ADtima/1198317040?i=1198317078",
        Youtube = "https://music.youtube.com/watch?v=Hr2Kn6CozzY&si=XnBW5vZj2z7OgIVS"
            },
            new Musica() {
                Id = 196,
                Título = "Na Fé Firmão",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:05"),
        Spotify = "https://open.spotify.com/intl-pt/track/0TYKO6toBeKLbyD18AVTNU?si=44ae992d5d094d98",
        AppleMusic = "https://music.apple.com/br/album/na-f%C3%A9-firm%C3%A3o/1198317040?i=1198317079",
        Youtube = "https://music.youtube.com/watch?v=3Qjrtsg5HXo&si=n1ScgQKzIRZU7xbZ"
            },
            new Musica() {
                Id = 197,
                Título = "12 de Outubro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("3:30"),
        Spotify = "https://open.spotify.com/intl-pt/track/4Nqj9K6kxvIr4PnvtI1RRA?si=79ea86d595ac4e84",
        AppleMusic = "https://music.apple.com/br/album/12-de-outubro/1198317040?i=1198317080",
        Youtube = "https://music.youtube.com/watch?v=b6XO9GGQDqw&si=m_cteFipo47DyWxl"
            },
            new Musica() {
                Id = 198,
                Título = "Eu Sou 157",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("8:49"),
        Spotify = "https://open.spotify.com/intl-pt/track/33UECsx4DcDRampb2ah316?si=02f3f8f8415d4e0a",
        AppleMusic = "https://music.apple.com/br/album/eu-sou-157/1198317040?i=1198317081",
        Youtube = "https://music.youtube.com/watch?v=fgysUhl98As&si=Ayvo-g0jwcsvhbI4"
            },
            new Musica() {
                Id = 199,
                Título = "A Vida É Desafio",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:13"),
        Spotify = "https://open.spotify.com/intl-pt/track/4mZu6NuOntvYZqCZPrxTqT?si=dd6baafb4c344173",
        AppleMusic = "https://music.apple.com/br/album/a-vida-%C3%A9-desafio/1198317040?i=1198317082",
        Youtube = "https://music.youtube.com/watch?v=Wb3rvC6z5ao&si=B48ryiwGGr0oT4PU"
            },
            new Musica() {
                Id = 200,
                Título = "1 por Amor, 2 por Dinheiro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:58"),
        Spotify = "https://open.spotify.com/intl-pt/track/0VQ1mXWqoXynNmc0wdligL?si=7d472a2b750641cd",
        AppleMusic = "https://music.apple.com/br/album/1-por-amor-2-por-dinheiro/1198317040?i=1198317083",
        Youtube = "https://music.youtube.com/watch?v=JovdffVqJF4&si=PoBdSA4uUHXp0o7t"
            },
            new Musica() {
                Id = 201,
                Título = "De Volta À Cena",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("2:01"),
        Spotify = "https://open.spotify.com/intl-pt/track/16oVqtzrcrdzQvtIRnA2Wx?si=6ce171ba988043b2",
        AppleMusic = "https://music.apple.com/br/album/de-volta-%C3%A0-cena/1198317040?i=1198317084",
        Youtube = "https://music.youtube.com/watch?v=-2XWmz3BL2E&si=KEvmDmZjB5a6FioP"
            },
            new Musica() {
                Id = 202,
                Título = "Otus 500",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("2:11"),
        Spotify = "https://open.spotify.com/intl-pt/track/3tuMjoF61Uo54BPVzV4e0d?si=928873c4f72b4899",
        AppleMusic = "https://music.apple.com/br/album/otus-500/1198317040?i=1198317085",
        Youtube = "https://music.youtube.com/watch?v=JWQDQgkjOFY&si=b0p7znSk28BvERQH"
            },
            new Musica() {
                Id = 203,
                Título = "Crime Vai e Vem",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:55"),
        Spotify = "https://open.spotify.com/intl-pt/track/29JxbOQf5YFFpqWgNauToo?si=5ec33c26b3ff4846",
        AppleMusic = "https://music.apple.com/br/album/crime-vai-e-vem/1198317040?i=1198317086",
        Youtube = "https://music.youtube.com/watch?v=Npl2rJ5lzHE&si=8LzEtK11rHcQdzlf"
            },
            new Musica() {
                Id = 204,
                Título = "Jesus Chorou",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:51"),
        Spotify = "https://open.spotify.com/intl-pt/track/5wZUvwWGKaZ6NG8yckZcTM?si=b9e6a27d33734497",
        AppleMusic = "https://music.apple.com/br/album/jesus-chorou/1198317040?i=1198317087",
        Youtube = "https://music.youtube.com/watch?v=jLfWZ0nhTAE&si=rJJENiAdy1nCjkED"
            },
            new Musica() {
                Id = 205,
                Título = "Fone (Intro)",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("1:56"),
        Spotify = "https://open.spotify.com/intl-pt/track/1QEit92Juvj8i9QrM60gpn?si=da7e1a81dba64d70",
        AppleMusic = "https://music.apple.com/br/album/fone-intro/1198317040?i=1198317088",
        Youtube = "https://music.youtube.com/watch?v=7zHFe8qaf9Q&si=1P8Gp1vX2zQT4kg8"
            },
            new Musica() {
                Id = 206,
                Título = "Estilo Cachorro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:17"),
        Spotify = "https://open.spotify.com/intl-pt/track/2tR8iLdCeYhVcyPZvN6T7X?si=2dad9da569b8475d",
        AppleMusic = "https://music.apple.com/br/album/estilo-cachorro/1198317040?i=1198317089",
        Youtube = "https://music.youtube.com/watch?v=q_xeCu3P9hU&si=XS3RUSMGTEK9vkx_"
            },
            new Musica() {
                Id = 207,
                Título = "Vida Loka, Pt. 2",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:50"),
        Spotify = "https://open.spotify.com/intl-pt/track/4nTrxp4aH0g2yLVPkFmljF?si=e66780a58a57434e",
        AppleMusic = "https://music.apple.com/br/album/vida-loka-pt-2/1198317040?i=1198317090",
        Youtube = "https://music.youtube.com/watch?v=Fu5kcgz73TY&si=ZxOg0rfHwPiyQ24T"
            },
            new Musica() {
                Id = 208,
                Título = "Expresso da Meia-Noite",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:21"),
        Spotify = "https://open.spotify.com/intl-pt/track/6CI6QHlg9ejvkWOTOni5oX?si=efb0f334ac0a415b",
        AppleMusic = "https://music.apple.com/br/album/expresso-da-meia-noite/1198317040?i=1198317091",
        Youtube = "https://music.youtube.com/watch?v=flpOCM7OXDQ&si=bML-4jKlbY2bkuyF"
            },
            new Musica() {
                Id = 209,
                Título = "Trutas e Quebradas",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:17"),
        Spotify = "https://open.spotify.com/intl-pt/track/6xmtjVIcjMRdgdB1sywkjb?si=7901eb3bbf744144",
        AppleMusic = "https://music.apple.com/br/album/trutas-e-quebradas/1198317040?i=1198317096",
        Youtube = "https://music.youtube.com/watch?v=tiPAMEtI38k&si=5MjRak4G7wE3ptxz"
            },
            new Musica() {
                Id = 210,
                Título = "Da Ponte pra Cá",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("8:47"),
        Spotify = "https://open.spotify.com/intl-pt/track/77ZXEJcwC7r4gfodNwERJz?si=8f38d0eaa5534781",
        AppleMusic = "https://music.apple.com/br/album/da-ponte-pra-c%C3%A1/1198317040?i=1198317097",
        Youtube = "https://music.youtube.com/watch?v=Xe8DN92jtbg&si=uM7wwS4WXkEbidVu"
            },
        };
        builder.Entity<Musica>().HasData(musicas);
        #endregion

        #region Populate Artista
        List<Artista> artistas = new(){
            new Artista() {
                Id = 1,
                Nome = "Future, Metro Boomin"
            },
            new Artista() {
                Id = 2,
                Nome = "Billie Eilish"
            },
            new Artista() {
                Id = 3,
                Nome = "Lady Gaga, Bruno Mars"
            },
            new Artista() {
                Id = 4,
                Nome = "Sabrina Carpenter"
            },
            new Artista() {
                Id = 5,
                Nome = "21 Savage"
            },
            new Artista() {
                Id = 6,
                Nome = "Travis Scott"
            },
            new Artista() {
                Id = 7,
                Nome = "Kendrick Lamar"
            },
            new Artista() {
                Id = 8,
                Nome = "Matuê"
            },
            new Artista() {
                Id = 9,
                Nome = "Wiu"
            },
            new Artista() {
                Id = 10,
                Nome = "XG"
            },
            new Artista() {
                Id = 11,
                Nome = "HARDY"
            },
            new Artista() {
                Id = 12,
                Nome = "Linkin Park"
            },
            new Artista() {
                Id = 13,
                Nome = "Charli XCX "
            },
            new Artista() {
                Id = 14,
                Nome = "Dj Luan Gomes"
            },
            new Artista() {
                Id = 15,
                Nome = "Drake"
            },
            new Artista() {
                Id = 16,
                Nome = "Playboi Carti e The Weeknd"
            },
            new Artista() {
                Id = 17,
                Nome = "Tommy Richman"
            },
            new Artista() {
                Id = 18,
                Nome = "Coldplay"
            },
            new Artista() {
                Id = 19,
                Nome = "Ariana Grande"
            },
            new Artista() {
                Id = 20,
                Nome = "Kanye West"
            },
            new Artista() {
                Id = 21,
                Nome = "DJ Oreia, Mc Brinquedo, MC Cebezinho, Mc Laranjinha, MC Tuto e THE BOX"
            },
            new Artista() {
                Id = 22,
                Nome = "Yeat"
            },
            new Artista() {
                Id = 23,
                Nome = "Tyler, The Creator"
            },
            new Artista() {
                Id = 24,
                Nome = "DJ Glenner e MC Tuto"
            },
            new Artista() {
                Id = 25,
                Nome = "Bruno Mars e ROSÉ"
            },
            new Artista() {
                Id = 26,
                Nome = "Racionais MC's"
            },
        };
        builder.Entity<Artista>().HasData(artistas);
        #endregion

        #region Populate Generos
        List<Genero> generos = new() {
            new Genero() {
                Id = 1,
                Nome = "Pop"
            },
            new Genero() {
                Id = 2,
                Nome = "Rap/Hip-Hop"
            },
            new Genero() {
                Id = 3,
                Nome = "Rock"
            },
            new Genero() {
                Id = 4,
                Nome = "Funk"
            },
            new Genero() {
                Id = 5,
                Nome = "Eletrônica"
            },

        };
        builder.Entity<Genero>().HasData(generos);
        #endregion 

        #region Populate MusicaGenero
        List<MusicaGenero> musicaGeneros = new(){
            new MusicaGenero() {
                MusicaId = 1,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 2,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 3,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 4,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 5,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 6,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 7,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 8,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 9,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 10,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 11,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 12,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 13,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 14,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 15,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 16,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 17,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 18,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 19,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 20,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 21,
                GeneroId = 3,
            },
            new MusicaGenero() {
                MusicaId = 22,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 23,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 24,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 25,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 26,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 27,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 28,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 29,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 30,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 31,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 32,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 33,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 34,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 35,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 36,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 37,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 38,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 39,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 40,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 41,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 42,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 43,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 44,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 45,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 46,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 47,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 48,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 49,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 50,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 51,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 52,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 53,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 54,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 55,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 56,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 57,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 58,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 59,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 60,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 61,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 62,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 63,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 64,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 65,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 66,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 67,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 68,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 69,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 70,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 71,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 72,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 73,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 74,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 75,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 76,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 77,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 78,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 79,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 80,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 81,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 82,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 83,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 84,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 85,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 86,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 87,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 88,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 89,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 90,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 91,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 92,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 93,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 94,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 95,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 96,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 97,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 98,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 99,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 100,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 101,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 102,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 103,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 104,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 105,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 106,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 107,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 108,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 109,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 110,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 111,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 112,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 113,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 114,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 115,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 116,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 117,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 118,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 119,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 120,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 121,
                GeneroId = 3,
            },
            new MusicaGenero() {
                MusicaId = 122,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 123,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 124,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 125,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 126,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 127,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 128,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 129,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 130,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 131,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 132,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 133,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 134,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 135,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 136,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 137,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 138,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 139,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 140,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 141,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 142,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 143,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 144,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 145,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 146,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 147,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 148,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 149,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 150,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 151,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 152,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 153,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 154,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 155,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 156,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 157,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 158,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 159,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 160,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 161,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 162,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 163,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 164,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 165,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 166,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 167,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 168,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 169,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 170,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 171,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 172,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 173,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 174,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 175,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 176,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 177,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 178,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 179,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 180,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 181,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 182,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 183,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 184,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 185,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 186,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 187,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 188,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 189,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 190,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 191,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 192,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 193,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 194,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 195,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 196,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 197,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 198,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 199,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 200,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 201,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 202,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 203,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 204,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 205,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 206,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 207,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 208,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 209,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 210,
                GeneroId = 2,
            },
        };
        builder.Entity<MusicaGenero>().HasData(musicaGeneros);
        #endregion


        #region Populate AlbumArtista
        List<AlbumArtista> albumArtistas = new() {
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 1,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 2,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 3,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 4,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 5,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 6,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 7,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 8,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 9,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 10,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 11,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 12,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 13,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 14,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 15,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 16,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 17,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 18,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 19,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 20,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 21,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 22,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 23,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 24,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 25,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 26,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 27,
            },
            new AlbumArtista() {
                AlbumId = 10,
                ArtistaId = 3,
                MusicaId = 28,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 29,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 30,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 31,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 32,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 33,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 34,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 35,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 36,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 37,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 38,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 39,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 40,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 41,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 42,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 43,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 44,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 45,
            },
            new AlbumArtista() {
                AlbumId = 12,
                ArtistaId = 15,
                MusicaId = 46,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 47,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 48,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 49,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 50,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 51,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 52,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 53,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 54,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 55,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 56,
            },
            new AlbumArtista() {
                AlbumId = 9,
                ArtistaId = 7,
                MusicaId = 57,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 58,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 59,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 60,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 61,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 62,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 63,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 64,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 65,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 66,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 67,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 68,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 69,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 70,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 71,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 72,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 73,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 74,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 75,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 6,
                MusicaId = 76,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 77,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 78,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 79,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 80,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 81,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 82,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 83,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 84,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 85,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 86,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 87,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 88,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 89,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 90,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 91,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 92,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 93,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 94,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 95,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 96,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 97,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 98,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 99,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 100,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 101,
            },
            new AlbumArtista() {
                AlbumId = 14,
                ArtistaId = 7,
                MusicaId = 102,
            },
            new AlbumArtista() {
                AlbumId = 11,
                ArtistaId = 10,
                MusicaId = 103,
            },
            new AlbumArtista() {
                AlbumId = 13,
                ArtistaId = 14,
                MusicaId = 104,
            },
            new AlbumArtista() {
                AlbumId = 15,
                ArtistaId = 16,
                MusicaId = 105,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 106,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 107,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 108,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 109,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 110,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 111,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 112,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 113,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 114,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 115,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 116,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 117,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 118,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 119,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 120,
            },
            new AlbumArtista() {
                AlbumId = 26,
                ArtistaId = 12,
                MusicaId = 121,
            },
            new AlbumArtista() {
                AlbumId = 16,
                ArtistaId = 17,
                MusicaId = 122,
            },
            new AlbumArtista() {
                AlbumId = 17,
                ArtistaId = 18,
                MusicaId = 123,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 124,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 125,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 126,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 127,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 128,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 129,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 130,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 131,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 132,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 133,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 134,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 135,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 136,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 137,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 138,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 139,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 140,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 141,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 142,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 143,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 144,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 145,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 146,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 147,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 148,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 149,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 150,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 151,
            },
            new AlbumArtista() {
                AlbumId = 20,
                ArtistaId = 21,
                MusicaId = 152,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 153,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 154,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 155,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 156,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 157,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 158,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 159,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 160,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 161,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 162,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 163,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 164,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 165,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 166,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 167,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 168,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 169,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 170,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 171,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 172,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 173,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 174,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 175,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 176,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 177,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 178,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 179,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 180,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 181,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 182,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 183,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 184,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 185,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 186,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 187,
            },
            new AlbumArtista() {
                AlbumId = 23,
                ArtistaId = 24,
                MusicaId = 188,
            },
            new AlbumArtista() {
                AlbumId = 24,
                ArtistaId = 25,
                MusicaId = 189,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 190,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 191,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 192,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 193,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 194,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 195,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 196,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 197,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 198,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 199,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 200,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 201,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 202,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 203,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 204,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 205,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 206,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 207,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 208,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 209,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 210,
            },
        };
        builder.Entity<AlbumArtista>().HasData(albumArtistas);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Moderador",
               NormalizedName = "MODERADOR"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new() {
            new IdentityUser(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "admin@aboutsongs.com",
                NormalizedEmail = "ADMIN@ABOUTSONGS.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "zecapagodinho3");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Administrador",
                Foto = "/img/usuarios/admin.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

    }
}