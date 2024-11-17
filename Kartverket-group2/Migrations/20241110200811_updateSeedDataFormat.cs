using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedDataFormat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"09. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 19:08:11\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "09. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"08. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 18:08:11\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "08. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"07. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 17:08:11\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "07. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"06. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 16:08:11\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "06. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"05. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 15:08:11\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "05. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"04. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 14:08:11\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "04. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"03. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 13:08:11\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "03. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"02. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 12:08:11\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "02. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"01. nov. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 11:08:11\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "01. nov. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"31. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 10:08:11\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "31. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"30. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 09:08:11\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "30. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"29. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 08:08:11\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "29. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"28. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 07:08:11\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "28. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"27. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 06:08:11\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "27. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"26. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 05:08:11\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "26. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"25. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 04:08:11\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "25. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"24. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 03:08:11\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "24. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"23. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 02:08:11\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "23. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"22. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 01:08:11\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "22. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"21. okt. 2024 20:08:11\",\"lastEdited\":\"10. nov. 2024 00:08:11\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "21. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"20. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 23:08:11\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "20. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"19. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 22:08:11\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "19. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"18. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 21:08:11\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "18. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"17. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 20:08:11\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "17. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"16. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 19:08:11\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "16. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"15. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 18:08:11\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "15. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"14. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 17:08:11\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "14. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"13. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 16:08:11\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "13. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"12. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 15:08:11\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "12. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"11. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 14:08:11\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "11. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"10. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 13:08:11\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "10. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"09. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 12:08:11\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "09. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"08. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 11:08:11\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "08. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"07. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 10:08:11\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "07. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"06. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 09:08:11\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "06. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"05. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 08:08:11\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "05. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"04. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 07:08:11\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "04. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"03. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 06:08:11\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "03. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"02. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 05:08:11\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "02. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"01. okt. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 04:08:11\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "01. okt. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"30. sep. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 03:08:11\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "30. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"29. sep. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 02:08:11\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "29. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"28. sep. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 01:08:11\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "28. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"27. sep. 2024 20:08:11\",\"lastEdited\":\"09. nov. 2024 00:08:11\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "27. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"26. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 23:08:11\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "26. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"25. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 22:08:11\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "25. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"24. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 21:08:11\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "24. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"23. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 20:08:11\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "23. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"22. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 19:08:11\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "22. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"21. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 18:08:11\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "21. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"20. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 17:08:11\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "20. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"19. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 16:08:11\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "19. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"18. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 15:08:11\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "18. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"17. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 14:08:11\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "17. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"16. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 13:08:11\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "16. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"15. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 12:08:11\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "15. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"14. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 11:08:11\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "14. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"13. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 10:08:11\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "13. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"12. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 09:08:11\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "12. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"11. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 08:08:11\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "11. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"10. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 07:08:11\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "10. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"09. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 06:08:11\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "09. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"08. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 05:08:11\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "08. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"07. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 04:08:11\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "07. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"06. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 03:08:11\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "06. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"05. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 02:08:11\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "05. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"04. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 01:08:11\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "04. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"03. sep. 2024 20:08:11\",\"lastEdited\":\"08. nov. 2024 00:08:11\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "03. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"02. sep. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 23:08:11\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "02. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"01. sep. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 22:08:11\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "01. sep. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"31. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 21:08:11\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "31. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"30. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 20:08:11\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "30. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"29. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 19:08:11\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "29. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"28. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 18:08:11\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "28. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"27. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 17:08:11\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "27. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"26. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 16:08:11\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "26. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"25. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 15:08:11\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "25. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"24. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 14:08:11\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "24. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"23. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 13:08:11\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "23. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"22. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 12:08:11\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "22. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"21. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 11:08:11\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "21. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"20. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 10:08:11\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "20. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"19. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 09:08:11\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "19. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"18. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 08:08:11\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "18. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"17. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 07:08:11\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "17. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"16. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 06:08:11\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "16. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"15. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 05:08:11\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "15. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"14. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 04:08:11\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "14. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"13. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 03:08:11\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "13. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"12. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 02:08:11\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "12. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"11. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 01:08:11\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "11. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"10. aug. 2024 20:08:11\",\"lastEdited\":\"07. nov. 2024 00:08:11\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "10. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"09. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 23:08:11\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "09. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"08. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 22:08:11\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "08. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"07. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 21:08:11\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "07. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"06. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 20:08:11\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "06. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"05. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 19:08:11\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "05. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"04. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 18:08:11\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "04. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"03. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 17:08:11\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "03. aug. 2024 20:08:11" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"02. aug. 2024 20:08:11\",\"lastEdited\":\"06. nov. 2024 16:08:11\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "02. aug. 2024 20:08:11" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"09. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 19:03:52\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "09. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"08. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 18:03:52\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "08. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"07. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 17:03:52\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "07. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"06. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 16:03:52\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "06. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"05. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 15:03:52\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "05. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"04. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 14:03:52\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "04. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"03. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 13:03:52\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "03. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"02. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 12:03:52\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "02. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"01. nov.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 11:03:52\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "01. nov.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"31. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 10:03:52\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "31. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"30. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 09:03:52\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "30. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"29. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 08:03:52\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "29. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"28. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 07:03:52\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "28. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"27. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 06:03:52\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "27. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"26. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 05:03:52\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "26. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"25. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 04:03:52\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "25. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"24. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 03:03:52\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "24. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"23. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 02:03:52\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "23. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"22. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 01:03:52\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "22. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"21. okt.. 2024 20:03:52\",\"lastEdited\":\"10. nov.. 2024 00:03:52\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "21. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"20. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 23:03:52\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "20. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"19. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 22:03:52\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "19. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"18. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 21:03:52\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "18. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"17. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 20:03:52\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "17. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"16. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 19:03:52\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "16. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"15. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 18:03:52\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "15. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"14. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 17:03:52\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "14. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"13. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 16:03:52\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "13. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"12. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 15:03:52\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "12. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"11. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 14:03:52\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "11. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"10. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 13:03:52\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "10. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"09. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 12:03:52\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "09. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"08. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 11:03:52\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "08. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"07. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 10:03:52\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "07. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"06. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 09:03:52\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "06. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"05. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 08:03:52\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "05. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"04. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 07:03:52\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "04. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"03. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 06:03:52\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "03. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"02. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 05:03:52\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "02. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"01. okt.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 04:03:52\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "01. okt.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"30. sep.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 03:03:52\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "30. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"29. sep.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 02:03:52\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "29. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"28. sep.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 01:03:52\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "28. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"27. sep.. 2024 20:03:52\",\"lastEdited\":\"09. nov.. 2024 00:03:52\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "27. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"26. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 23:03:52\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "26. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"25. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 22:03:52\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "25. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"24. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 21:03:52\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "24. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"23. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 20:03:52\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "23. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"22. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 19:03:52\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "22. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"21. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 18:03:52\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "21. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"20. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 17:03:52\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "20. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"19. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 16:03:52\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "19. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"18. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 15:03:52\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "18. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"17. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 14:03:52\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "17. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"16. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 13:03:52\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "16. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"15. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 12:03:52\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "15. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"14. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 11:03:52\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "14. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"13. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 10:03:52\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "13. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"12. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 09:03:52\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "12. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"11. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 08:03:52\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "11. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"10. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 07:03:52\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "10. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"09. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 06:03:52\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "09. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"08. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 05:03:52\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "08. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"07. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 04:03:52\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "07. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"06. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 03:03:52\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "06. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"05. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 02:03:52\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "05. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"04. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 01:03:52\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "04. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"03. sep.. 2024 20:03:52\",\"lastEdited\":\"08. nov.. 2024 00:03:52\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "03. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"02. sep.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 23:03:52\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "02. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"01. sep.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 22:03:52\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "01. sep.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"31. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 21:03:52\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "31. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"30. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 20:03:52\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "30. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"29. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 19:03:52\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "29. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"28. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 18:03:52\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "28. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"27. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 17:03:52\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "27. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"26. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 16:03:52\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "26. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"25. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 15:03:52\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "25. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"24. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 14:03:52\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "24. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"23. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 13:03:52\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "23. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"22. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 12:03:52\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "22. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"21. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 11:03:52\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "21. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"20. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 10:03:52\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "20. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"19. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 09:03:52\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "19. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"18. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 08:03:52\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "18. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"17. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 07:03:52\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "17. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"16. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 06:03:52\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "16. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"15. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 05:03:52\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "15. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"14. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 04:03:52\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "14. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"13. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 03:03:52\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "13. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"12. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 02:03:52\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "12. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"11. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 01:03:52\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "11. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"10. aug.. 2024 20:03:52\",\"lastEdited\":\"07. nov.. 2024 00:03:52\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "10. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"09. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 23:03:52\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "09. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"08. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 22:03:52\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "08. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"07. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 21:03:52\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "07. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"06. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 20:03:52\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "06. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"05. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 19:03:52\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "05. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"04. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 18:03:52\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "04. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"03. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 17:03:52\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "03. aug.. 2024 20:03:52" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"02. aug.. 2024 20:03:52\",\"lastEdited\":\"06. nov.. 2024 16:03:52\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "02. aug.. 2024 20:03:52" });
        }
    }
}
