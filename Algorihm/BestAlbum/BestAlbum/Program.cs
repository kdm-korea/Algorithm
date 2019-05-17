using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://programmers.co.kr/learn/courses/30/lessons/42579?language=csharp
/// Algorithm Problem in programers
/// </summary>
namespace BestAlbum
{
    class Program
    {
        static void Main(string[] args) {
            string[] genres = new string[] { "classic", "pop", "classic", "classic", "pop" };
            int[] plays = new int[] { 500, 600, 150, 800, 2500 };

            solution(genres, plays);
        }

        public static int[] solution(string[] genres, int[] plays) {
            int[] sings = new int[] { };
            List<SingInfo> list = new List<SingInfo>();

            for (int idx = 0; idx < genres.Length; idx++) {
                list.Add(new SingInfo(genres[idx], plays[idx], idx));
            }

            list = list.OrderByDescending(sing => sing.PlayCount).ToList();

            foreach (var item in list) {
                Console.WriteLine(item.Music);
            }

            int tmp = 0;
            while (true) {
                sings[tmp++] = list[0].Music;
            }
            return null;
        }
    }

    class SingInfo
    {
        private string genre;
        private int playCount;
        private int music;

        public SingInfo(string genre, int playCount, int music) {
            this.genre = genre;
            this.playCount = playCount;
            this.music = music;
        }

        public string Genre { get => genre; set => genre = value; }

        public int PlayCount { get => playCount; set => playCount = value; }

        public int Music { get => music; set => music = value; }
    }
}

