using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace Kartverket_group2.Models
{
    public class Shape
    {
        [Key]
        public int Id { get; set; }  // Unique identifier for each shape
        public string Type { get; set; }  // The type of shape, e.g., 'Circle', 'Polygon'
        public string Coordinates { get; set; }  // JSON or stringified coordinates of the shape
        public string Comment { get; set; }  // User comment for the shape

        public string addedAt { get; set; }
        public string lastEdited { get; set; }
    }
}
