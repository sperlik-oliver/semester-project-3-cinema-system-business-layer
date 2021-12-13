using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Hall
    {
        public long Id { get; set; }
        
        public int HallSize { get; set; }


        public Branch Branch { get; set; }
        public List<Play> Programme { get; set; }


        //generated in the constructor
        public List<Tuple<int, int>> Seats { get; set; }
        

        private void CreateSeats(int rows, int columns) {
            for (var i = 1; i <= rows; i++) {
                for (var z = 1; z <= columns; z++) {
                    var tuple = new Tuple<int, int>(i, z);
                    Seats.Add(tuple);
                }
            }
        }


        public void PrintArray() {
            var totalRows = Seats.Max().Item1;
            var totalColumns = Seats.Max().Item2;
            foreach (var seat in Seats) {
                Console.WriteLine("Seat :: {");
                Console.WriteLine("row :: " + seat.Item1);
                Console.WriteLine("column :: " + seat.Item2);
                Console.WriteLine("}");
                Console.WriteLine("");
            }

            Console.WriteLine("Total Rows :: " + totalRows);
            Console.WriteLine("");
            Console.WriteLine("Total Columns :: " + totalColumns);
            Console.WriteLine("");
            Console.WriteLine("Total Seats :: " + totalColumns * totalRows);
        }

        public void SetSeats() {
            Seats = new List<Tuple<int, int>>();
            if (HallSize == 1) {
                CreateSeats(6, 8);
            }

            //Hall size medium = 12 rows = 14 columns
            else if (HallSize == 2) {
                CreateSeats(12, 14);
            }

            //Hall size large = 15 rows, 20 columns
            else if (HallSize == 3) {
                CreateSeats(15, 20);
            }
            else {
                throw new Exception("Invalid hall size");
            }
        }
    }
}