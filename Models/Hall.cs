using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Hall
    {
        public long Id { get; set; }
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
        

        public void SetSeats() {
            Seats = new List<Tuple<int, int>>();
            CreateSeats(6, 8);
            
        }
    }
}