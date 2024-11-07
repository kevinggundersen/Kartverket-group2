using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-02T14:46:38.0436125Z\",\"lastEdited\":\"2024-11-03T13:46:38.0436127Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-02T14:46:38.0436085Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-11-01T14:46:38.0436139Z\",\"lastEdited\":\"2024-11-03T12:46:38.0436139Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "2024-11-01T14:46:38.0436135Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-31T14:46:38.0436144Z\",\"lastEdited\":\"2024-11-03T11:46:38.0436145Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-31T14:46:38.0436142Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-30T14:46:38.0436150Z\",\"lastEdited\":\"2024-11-03T10:46:38.0436151Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-30T14:46:38.0436147Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-29T14:46:38.0436155Z\",\"lastEdited\":\"2024-11-03T09:46:38.0436155Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-29T14:46:38.0436152Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-28T14:46:38.0436161Z\",\"lastEdited\":\"2024-11-03T08:46:38.0436162Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "2024-10-28T14:46:38.0436159Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-27T14:46:38.0436167Z\",\"lastEdited\":\"2024-11-03T07:46:38.0436167Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-27T14:46:38.0436164Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-26T14:46:38.0436217Z\",\"lastEdited\":\"2024-11-03T06:46:38.0436218Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-26T14:46:38.0436169Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-25T14:46:38.0436222Z\",\"lastEdited\":\"2024-11-03T05:46:38.0436223Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-25T14:46:38.0436220Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-24T14:46:38.0436229Z\",\"lastEdited\":\"2024-11-03T04:46:38.0436229Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-24T14:46:38.0436226Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-23T14:46:38.0436234Z\",\"lastEdited\":\"2024-11-03T03:46:38.0436234Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-23T14:46:38.0436231Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-22T14:46:38.0436239Z\",\"lastEdited\":\"2024-11-03T02:46:38.0436239Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "2024-10-22T14:46:38.0436236Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-21T14:46:38.0436244Z\",\"lastEdited\":\"2024-11-03T01:46:38.0436245Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-21T14:46:38.0436241Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-20T14:46:38.0436249Z\",\"lastEdited\":\"2024-11-03T00:46:38.0436250Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-20T14:46:38.0436246Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-19T14:46:38.0436254Z\",\"lastEdited\":\"2024-11-02T23:46:38.0436255Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-19T14:46:38.0436251Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-18T14:46:38.0436259Z\",\"lastEdited\":\"2024-11-02T22:46:38.0436260Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-18T14:46:38.0436256Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-17T14:46:38.0436264Z\",\"lastEdited\":\"2024-11-02T21:46:38.0436265Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-17T14:46:38.0436262Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-16T14:46:38.0436306Z\",\"lastEdited\":\"2024-11-02T20:46:38.0436307Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "2024-10-16T14:46:38.0436303Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-15T14:46:38.0436311Z\",\"lastEdited\":\"2024-11-02T19:46:38.0436312Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-15T14:46:38.0436309Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-14T14:46:38.0436316Z\",\"lastEdited\":\"2024-11-02T18:46:38.0436317Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-14T14:46:38.0436314Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-13T14:46:38.0436321Z\",\"lastEdited\":\"2024-11-02T17:46:38.0436322Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-13T14:46:38.0436319Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-12T14:46:38.0436326Z\",\"lastEdited\":\"2024-11-02T16:46:38.0436327Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-12T14:46:38.0436324Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-11T14:46:38.0436331Z\",\"lastEdited\":\"2024-11-02T15:46:38.0436332Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-11T14:46:38.0436329Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-10T14:46:38.0436336Z\",\"lastEdited\":\"2024-11-02T14:46:38.0436337Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "2024-10-10T14:46:38.0436333Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-09T14:46:38.0436341Z\",\"lastEdited\":\"2024-11-02T13:46:38.0436342Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-09T14:46:38.0436338Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-08T14:46:38.0436346Z\",\"lastEdited\":\"2024-11-02T12:46:38.0436347Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-08T14:46:38.0436344Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-07T14:46:38.0436351Z\",\"lastEdited\":\"2024-11-02T11:46:38.0436352Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-07T14:46:38.0436348Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-06T14:46:38.0436388Z\",\"lastEdited\":\"2024-11-02T10:46:38.0436389Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-06T14:46:38.0436386Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-05T14:46:38.0436394Z\",\"lastEdited\":\"2024-11-02T09:46:38.0436395Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-05T14:46:38.0436391Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-04T14:46:38.0436399Z\",\"lastEdited\":\"2024-11-02T08:46:38.0436400Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "2024-10-04T14:46:38.0436396Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-03T14:46:38.0436404Z\",\"lastEdited\":\"2024-11-02T07:46:38.0436405Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-03T14:46:38.0436401Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-02T14:46:38.0436409Z\",\"lastEdited\":\"2024-11-02T06:46:38.0436410Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-02T14:46:38.0436407Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-10-01T14:46:38.0436414Z\",\"lastEdited\":\"2024-11-02T05:46:38.0436415Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-01T14:46:38.0436412Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-09-30T14:46:38.0436420Z\",\"lastEdited\":\"2024-11-02T04:46:38.0436421Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-30T14:46:38.0436417Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-09-29T14:46:38.0436425Z\",\"lastEdited\":\"2024-11-02T03:46:38.0436426Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-29T14:46:38.0436422Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-09-28T14:46:38.0436430Z\",\"lastEdited\":\"2024-11-02T02:46:38.0436431Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "2024-09-28T14:46:38.0436428Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-27T14:46:38.0436467Z\",\"lastEdited\":\"2024-11-02T01:46:38.0436467Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-27T14:46:38.0436433Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-26T14:46:38.0436472Z\",\"lastEdited\":\"2024-11-02T00:46:38.0436473Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-26T14:46:38.0436469Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-25T14:46:38.0436477Z\",\"lastEdited\":\"2024-11-01T23:46:38.0436478Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-25T14:46:38.0436474Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-24T14:46:38.0436482Z\",\"lastEdited\":\"2024-11-01T22:46:38.0436483Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-24T14:46:38.0436480Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-23T14:46:38.0436487Z\",\"lastEdited\":\"2024-11-01T21:46:38.0436488Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-23T14:46:38.0436485Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-22T14:46:38.0436492Z\",\"lastEdited\":\"2024-11-01T20:46:38.0436493Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "2024-09-22T14:46:38.0436490Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-21T14:46:38.0436497Z\",\"lastEdited\":\"2024-11-01T19:46:38.0436498Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-21T14:46:38.0436495Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-20T14:46:38.0436502Z\",\"lastEdited\":\"2024-11-01T18:46:38.0436503Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-20T14:46:38.0436500Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-19T14:46:38.0436508Z\",\"lastEdited\":\"2024-11-01T17:46:38.0436508Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-19T14:46:38.0436505Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-18T14:46:38.0436513Z\",\"lastEdited\":\"2024-11-01T16:46:38.0436514Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-18T14:46:38.0436510Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-17T14:46:38.0436535Z\",\"lastEdited\":\"2024-11-01T15:46:38.0436536Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-17T14:46:38.0436515Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-16T14:46:38.0436541Z\",\"lastEdited\":\"2024-11-01T14:46:38.0436542Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "2024-09-16T14:46:38.0436538Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-15T14:46:38.0436546Z\",\"lastEdited\":\"2024-11-01T13:46:38.0436547Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-15T14:46:38.0436544Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-14T14:46:38.0436551Z\",\"lastEdited\":\"2024-11-01T12:46:38.0436552Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-14T14:46:38.0436549Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-13T14:46:38.0436556Z\",\"lastEdited\":\"2024-11-01T11:46:38.0436557Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-13T14:46:38.0436554Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-12T14:46:38.0436562Z\",\"lastEdited\":\"2024-11-01T10:46:38.0436562Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-12T14:46:38.0436559Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-11T14:46:38.0436567Z\",\"lastEdited\":\"2024-11-01T09:46:38.0436567Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-11T14:46:38.0436564Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-10T14:46:38.0436572Z\",\"lastEdited\":\"2024-11-01T08:46:38.0436572Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "2024-09-10T14:46:38.0436569Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-09T14:46:38.0436577Z\",\"lastEdited\":\"2024-11-01T07:46:38.0436577Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-09T14:46:38.0436574Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-08T14:46:38.0436582Z\",\"lastEdited\":\"2024-11-01T06:46:38.0436582Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-08T14:46:38.0436579Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-07T14:46:38.0436640Z\",\"lastEdited\":\"2024-11-01T05:46:38.0436641Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-07T14:46:38.0436584Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-06T14:46:38.0436646Z\",\"lastEdited\":\"2024-11-01T04:46:38.0436646Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-06T14:46:38.0436643Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-05T14:46:38.0436651Z\",\"lastEdited\":\"2024-11-01T03:46:38.0436652Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-05T14:46:38.0436648Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-04T14:46:38.0436656Z\",\"lastEdited\":\"2024-11-01T02:46:38.0436657Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "2024-09-04T14:46:38.0436653Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-03T14:46:38.0436661Z\",\"lastEdited\":\"2024-11-01T01:46:38.0436662Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-03T14:46:38.0436658Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-02T14:46:38.0436666Z\",\"lastEdited\":\"2024-11-01T00:46:38.0436667Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-02T14:46:38.0436664Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-09-01T14:46:38.0436671Z\",\"lastEdited\":\"2024-10-31T23:46:38.0436672Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-01T14:46:38.0436668Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-08-31T14:46:38.0436676Z\",\"lastEdited\":\"2024-10-31T22:46:38.0436676Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-31T14:46:38.0436673Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-08-30T14:46:38.0436681Z\",\"lastEdited\":\"2024-10-31T21:46:38.0436681Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-30T14:46:38.0436678Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-08-29T14:46:38.0436749Z\",\"lastEdited\":\"2024-10-31T20:46:38.0436750Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "2024-08-29T14:46:38.0436700Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-28T14:46:38.0436754Z\",\"lastEdited\":\"2024-10-31T19:46:38.0436755Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-28T14:46:38.0436752Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-27T14:46:38.0436759Z\",\"lastEdited\":\"2024-10-31T18:46:38.0436760Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-27T14:46:38.0436757Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-26T14:46:38.0436764Z\",\"lastEdited\":\"2024-10-31T17:46:38.0436765Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-26T14:46:38.0436761Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-25T14:46:38.0436769Z\",\"lastEdited\":\"2024-10-31T16:46:38.0436770Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-25T14:46:38.0436766Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-24T14:46:38.0436774Z\",\"lastEdited\":\"2024-10-31T15:46:38.0436774Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-24T14:46:38.0436771Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-23T14:46:38.0436779Z\",\"lastEdited\":\"2024-10-31T14:46:38.0436779Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "2024-08-23T14:46:38.0436776Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-22T14:46:38.0436784Z\",\"lastEdited\":\"2024-10-31T13:46:38.0436784Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-22T14:46:38.0436781Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-21T14:46:38.0436789Z\",\"lastEdited\":\"2024-10-31T12:46:38.0436789Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-21T14:46:38.0436786Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-20T14:46:38.0436794Z\",\"lastEdited\":\"2024-10-31T11:46:38.0436794Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-20T14:46:38.0436791Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-19T14:46:38.0436830Z\",\"lastEdited\":\"2024-10-31T10:46:38.0436831Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-19T14:46:38.0436796Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-18T14:46:38.0436836Z\",\"lastEdited\":\"2024-10-31T09:46:38.0436836Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-18T14:46:38.0436833Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-17T14:46:38.0436841Z\",\"lastEdited\":\"2024-10-31T08:46:38.0436841Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "2024-08-17T14:46:38.0436838Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-16T14:46:38.0436846Z\",\"lastEdited\":\"2024-10-31T07:46:38.0436846Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-16T14:46:38.0436843Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-15T14:46:38.0436851Z\",\"lastEdited\":\"2024-10-31T06:46:38.0436851Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-15T14:46:38.0436848Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-14T14:46:38.0436856Z\",\"lastEdited\":\"2024-10-31T05:46:38.0436856Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-14T14:46:38.0436853Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-13T14:46:38.0436861Z\",\"lastEdited\":\"2024-10-31T04:46:38.0436861Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-13T14:46:38.0436858Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-12T14:46:38.0436865Z\",\"lastEdited\":\"2024-10-31T03:46:38.0436866Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-12T14:46:38.0436863Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-11T14:46:38.0436870Z\",\"lastEdited\":\"2024-10-31T02:46:38.0436871Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "2024-08-11T14:46:38.0436868Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-10T14:46:38.0436876Z\",\"lastEdited\":\"2024-10-31T01:46:38.0436876Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-10T14:46:38.0436873Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-09T14:46:38.0436912Z\",\"lastEdited\":\"2024-10-31T00:46:38.0436913Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-09T14:46:38.0436878Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-08T14:46:38.0436918Z\",\"lastEdited\":\"2024-10-30T23:46:38.0436918Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-08T14:46:38.0436915Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-07T14:46:38.0436923Z\",\"lastEdited\":\"2024-10-30T22:46:38.0436924Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-07T14:46:38.0436920Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-06T14:46:38.0436928Z\",\"lastEdited\":\"2024-10-30T21:46:38.0436928Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-06T14:46:38.0436925Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-05T14:46:38.0436933Z\",\"lastEdited\":\"2024-10-30T20:46:38.0436933Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "2024-08-05T14:46:38.0436930Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-04T14:46:38.0436938Z\",\"lastEdited\":\"2024-10-30T19:46:38.0436938Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-04T14:46:38.0436935Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-03T14:46:38.0436943Z\",\"lastEdited\":\"2024-10-30T18:46:38.0436943Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-03T14:46:38.0436940Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-02T14:46:38.0436948Z\",\"lastEdited\":\"2024-10-30T17:46:38.0436948Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-02T14:46:38.0436945Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-08-01T14:46:38.0436953Z\",\"lastEdited\":\"2024-10-30T16:46:38.0436953Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-01T14:46:38.0436950Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-07-31T14:46:38.0436958Z\",\"lastEdited\":\"2024-10-30T15:46:38.0436958Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-31T14:46:38.0436955Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-07-30T14:46:38.0436963Z\",\"lastEdited\":\"2024-10-30T14:46:38.0436995Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "2024-07-30T14:46:38.0436960Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-07-29T14:46:38.0437001Z\",\"lastEdited\":\"2024-10-30T13:46:38.0437001Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-29T14:46:38.0436998Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-28T14:46:38.0437006Z\",\"lastEdited\":\"2024-10-30T12:46:38.0437006Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-28T14:46:38.0437003Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-27T14:46:38.0437011Z\",\"lastEdited\":\"2024-10-30T11:46:38.0437011Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "2024-07-27T14:46:38.0437008Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-26T14:46:38.0437016Z\",\"lastEdited\":\"2024-10-30T10:46:38.0437017Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-26T14:46:38.0437013Z" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234512345,58.117571427]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-01T19:05:27.3583690Z\",\"lastEdited\":\"2024-11-02T18:05:27.3583691Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-01T19:05:27.3583657Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.2246902469,58.235142854]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-10-31T19:05:27.3583701Z\",\"lastEdited\":\"2024-11-02T17:05:27.3583702Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-31T19:05:27.3583698Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33703537035,58.352714281]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-30T19:05:27.3583706Z\",\"lastEdited\":\"2024-11-02T16:05:27.3583707Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-30T19:05:27.3583704Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.4493804938,58.470285708]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-29T19:05:27.3583712Z\",\"lastEdited\":\"2024-11-02T15:05:27.3583712Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-29T19:05:27.3583709Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.56172561725,58.587857135]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-28T19:05:27.3583716Z\",\"lastEdited\":\"2024-11-02T14:05:27.3583717Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-28T19:05:27.3583714Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.6740707407,58.705428562]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-27T19:05:27.3583762Z\",\"lastEdited\":\"2024-11-02T13:05:27.3583763Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "2024-10-27T19:05:27.3583758Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78641586415,58.822999989]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-26T19:05:27.3583768Z\",\"lastEdited\":\"2024-11-02T12:05:27.3583769Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-26T19:05:27.3583765Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.8987609876,58.940571416]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-25T19:05:27.3583773Z\",\"lastEdited\":\"2024-11-02T11:05:27.3583774Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-25T19:05:27.3583770Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01110611105,59.058142843]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-24T19:05:27.3583778Z\",\"lastEdited\":\"2024-11-02T10:05:27.3583779Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-24T19:05:27.3583775Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234512345,59.17571427]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-23T19:05:27.3583784Z\",\"lastEdited\":\"2024-11-02T09:05:27.3583785Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-23T19:05:27.3583782Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23579635795,59.293285697]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-22T19:05:27.3583790Z\",\"lastEdited\":\"2024-11-02T08:05:27.3583790Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-22T19:05:27.3583787Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.348141481399999,59.410857124]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-21T19:05:27.3583795Z\",\"lastEdited\":\"2024-11-02T07:05:27.3583796Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "2024-10-21T19:05:27.3583792Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46048660485,59.528428551]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-20T19:05:27.3583800Z\",\"lastEdited\":\"2024-11-02T06:05:27.3583801Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-20T19:05:27.3583797Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.5728317283,59.645999978]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-19T19:05:27.3583805Z\",\"lastEdited\":\"2024-11-02T05:05:27.3583806Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-19T19:05:27.3583802Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.68517685175,59.763571405]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-18T19:05:27.3583810Z\",\"lastEdited\":\"2024-11-02T04:05:27.3583811Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-18T19:05:27.3583808Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.7975219752,59.881142832]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-17T19:05:27.3583831Z\",\"lastEdited\":\"2024-11-02T03:05:27.3583831Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-17T19:05:27.3583828Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90986709865,59.998714259]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-16T19:05:27.3583836Z\",\"lastEdited\":\"2024-11-02T02:05:27.3583837Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-16T19:05:27.3583833Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.0222122221,60.116285686]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-15T19:05:27.3583842Z\",\"lastEdited\":\"2024-11-02T01:05:27.3583843Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "2024-10-15T19:05:27.3583839Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13455734555,60.233857113]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-14T19:05:27.3583847Z\",\"lastEdited\":\"2024-11-02T00:05:27.3583848Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-14T19:05:27.3583844Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.246902469,60.35142854]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-13T19:05:27.3583852Z\",\"lastEdited\":\"2024-11-01T23:05:27.3583853Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-13T19:05:27.3583849Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35924759245,60.468999967]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-12T19:05:27.3583857Z\",\"lastEdited\":\"2024-11-01T22:05:27.3583858Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-12T19:05:27.3583855Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.4715927159,60.586571394]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-11T19:05:27.3583862Z\",\"lastEdited\":\"2024-11-01T21:05:27.3583863Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-11T19:05:27.3583860Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58393783935,60.704142821]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-10T19:05:27.3583867Z\",\"lastEdited\":\"2024-11-01T20:05:27.3583868Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-10T19:05:27.3583865Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.6962829628,60.821714248]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-09T19:05:27.3583873Z\",\"lastEdited\":\"2024-11-01T19:05:27.3583873Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "2024-10-09T19:05:27.3583870Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.80862808625,60.939285675]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-08T19:05:27.3583926Z\",\"lastEdited\":\"2024-11-01T18:05:27.3583926Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-08T19:05:27.3583875Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.9209732097,61.056857102]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-07T19:05:27.3583931Z\",\"lastEdited\":\"2024-11-01T17:05:27.3583932Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-07T19:05:27.3583928Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03331833315,61.174428529]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-06T19:05:27.3583936Z\",\"lastEdited\":\"2024-11-01T16:05:27.3583937Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-06T19:05:27.3583934Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.1456634566,61.291999956]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-05T19:05:27.3583941Z\",\"lastEdited\":\"2024-11-01T15:05:27.3583942Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-05T19:05:27.3583939Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25800858005,61.409571383]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-04T19:05:27.3583946Z\",\"lastEdited\":\"2024-11-01T14:05:27.3583947Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-04T19:05:27.3583944Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.370353703500001,61.52714281]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-03T19:05:27.3583951Z\",\"lastEdited\":\"2024-11-01T13:05:27.3583952Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "2024-10-03T19:05:27.3583949Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48269882695,61.644714237]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-02T19:05:27.3583957Z\",\"lastEdited\":\"2024-11-01T12:05:27.3583957Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-02T19:05:27.3583954Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.595043950400001,61.762285664000004]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-01T19:05:27.3583961Z\",\"lastEdited\":\"2024-11-01T11:05:27.3583962Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-01T19:05:27.3583959Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.707389073849999,61.879857091]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-09-30T19:05:27.3583967Z\",\"lastEdited\":\"2024-11-01T10:05:27.3583967Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-30T19:05:27.3583964Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.8197341973,61.997428518]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-09-29T19:05:27.3583973Z\",\"lastEdited\":\"2024-11-01T09:05:27.3583974Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-29T19:05:27.3583970Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.93207932075,62.114999945]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-09-28T19:05:27.3584017Z\",\"lastEdited\":\"2024-11-01T08:05:27.3584018Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-28T19:05:27.3584014Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.0444244442,62.232571372]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-09-27T19:05:27.3584022Z\",\"lastEdited\":\"2024-11-01T07:05:27.3584023Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "2024-09-27T19:05:27.3584019Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.156769567649999,62.350142799]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-26T19:05:27.3584027Z\",\"lastEdited\":\"2024-11-01T06:05:27.3584028Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-26T19:05:27.3584024Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.2691146911,62.467714226]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-25T19:05:27.3584032Z\",\"lastEdited\":\"2024-11-01T05:05:27.3584033Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-25T19:05:27.3584030Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.38145981455,62.585285653]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-24T19:05:27.3584037Z\",\"lastEdited\":\"2024-11-01T04:05:27.3584038Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-24T19:05:27.3584034Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.493804938,62.70285708]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-23T19:05:27.3584042Z\",\"lastEdited\":\"2024-11-01T03:05:27.3584043Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-23T19:05:27.3584040Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60615006145,62.820428507]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-22T19:05:27.3584047Z\",\"lastEdited\":\"2024-11-01T02:05:27.3584048Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-22T19:05:27.3584044Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.7184951849,62.937999934000004]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-21T19:05:27.3584052Z\",\"lastEdited\":\"2024-11-01T01:05:27.3584053Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "2024-09-21T19:05:27.3584049Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83084030835,63.055571361]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-20T19:05:27.3584057Z\",\"lastEdited\":\"2024-11-01T00:05:27.3584058Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-20T19:05:27.3584054Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.9431854318,63.173142788]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-19T19:05:27.3584062Z\",\"lastEdited\":\"2024-10-31T23:05:27.3584063Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-19T19:05:27.3584060Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.05553055525,63.290714215]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-18T19:05:27.3584094Z\",\"lastEdited\":\"2024-10-31T22:05:27.3584095Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-18T19:05:27.3584091Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.1678756787,63.408285642]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-17T19:05:27.3584099Z\",\"lastEdited\":\"2024-10-31T21:05:27.3584100Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-17T19:05:27.3584097Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.28022080215,63.525857069]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-16T19:05:27.3584104Z\",\"lastEdited\":\"2024-10-31T20:05:27.3584105Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-16T19:05:27.3584102Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.3925659256,63.643428496]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-15T19:05:27.3584109Z\",\"lastEdited\":\"2024-10-31T19:05:27.3584110Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "2024-09-15T19:05:27.3584107Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.504911049050001,63.760999923]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-14T19:05:27.3584114Z\",\"lastEdited\":\"2024-10-31T18:05:27.3584115Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-14T19:05:27.3584112Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.6172561725,63.87857135]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-13T19:05:27.3584119Z\",\"lastEdited\":\"2024-10-31T17:05:27.3584120Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-13T19:05:27.3584117Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.729601295950001,63.996142777]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-12T19:05:27.3584124Z\",\"lastEdited\":\"2024-10-31T16:05:27.3584125Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-12T19:05:27.3584121Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.8419464194,64.113714204]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-11T19:05:27.3584129Z\",\"lastEdited\":\"2024-10-31T15:05:27.3584130Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-11T19:05:27.3584126Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.954291542850001,64.231285631]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-10T19:05:27.3584134Z\",\"lastEdited\":\"2024-10-31T14:05:27.3584135Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-10T19:05:27.3584131Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.066636666299999,64.348857058]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-09T19:05:27.3584139Z\",\"lastEdited\":\"2024-10-31T13:05:27.3584140Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "2024-09-09T19:05:27.3584136Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.17898178975,64.466428485]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-08T19:05:27.3584170Z\",\"lastEdited\":\"2024-10-31T12:05:27.3584171Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-08T19:05:27.3584141Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291326913199999,64.583999912]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-07T19:05:27.3584175Z\",\"lastEdited\":\"2024-10-31T11:05:27.3584176Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-07T19:05:27.3584173Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.40367203665,64.701571339]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-06T19:05:27.3584181Z\",\"lastEdited\":\"2024-10-31T10:05:27.3584181Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-06T19:05:27.3584178Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.516017160099999,64.819142766]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-05T19:05:27.3584186Z\",\"lastEdited\":\"2024-10-31T09:05:27.3584186Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-05T19:05:27.3584183Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62836228355,64.936714193]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-04T19:05:27.3584191Z\",\"lastEdited\":\"2024-10-31T08:05:27.3584191Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-04T19:05:27.3584188Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.740707407,65.05428562]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-03T19:05:27.3584196Z\",\"lastEdited\":\"2024-10-31T07:05:27.3584197Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "2024-09-03T19:05:27.3584193Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85305253045,65.171857047]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-02T19:05:27.3584201Z\",\"lastEdited\":\"2024-10-31T06:05:27.3584202Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-02T19:05:27.3584198Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.9653976539,65.289428474]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-01T19:05:27.3584206Z\",\"lastEdited\":\"2024-10-31T05:05:27.3584206Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-01T19:05:27.3584203Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07774277735,65.406999901]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-08-31T19:05:27.3584211Z\",\"lastEdited\":\"2024-10-31T04:05:27.3584211Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-31T19:05:27.3584208Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.1900879008,65.52457132800001]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-08-30T19:05:27.3584216Z\",\"lastEdited\":\"2024-10-31T03:05:27.3584216Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-30T19:05:27.3584213Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.30243302425,65.642142755]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-08-29T19:05:27.3584246Z\",\"lastEdited\":\"2024-10-31T02:05:27.3584247Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-29T19:05:27.3584218Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.4147781477,65.759714182]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-08-28T19:05:27.3584253Z\",\"lastEdited\":\"2024-10-31T01:05:27.3584254Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "2024-08-28T19:05:27.3584250Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.52712327115,65.877285609]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-27T19:05:27.3584258Z\",\"lastEdited\":\"2024-10-31T00:05:27.3584259Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-27T19:05:27.3584255Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.6394683946,65.994857036]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-26T19:05:27.3584263Z\",\"lastEdited\":\"2024-10-30T23:05:27.3584264Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-26T19:05:27.3584260Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75181351805,66.112428463]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-25T19:05:27.3584268Z\",\"lastEdited\":\"2024-10-30T22:05:27.3584269Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-25T19:05:27.3584265Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.864158641500001,66.22999989]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-24T19:05:27.3584273Z\",\"lastEdited\":\"2024-10-30T21:05:27.3584273Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-24T19:05:27.3584270Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.97650376495,66.347571317]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-23T19:05:27.3584278Z\",\"lastEdited\":\"2024-10-30T20:05:27.3584278Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-23T19:05:27.3584275Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.0888488884,66.465142744]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-22T19:05:27.3584283Z\",\"lastEdited\":\"2024-10-30T19:05:27.3584283Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "2024-08-22T19:05:27.3584280Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20119401185,66.582714171]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-21T19:05:27.3584288Z\",\"lastEdited\":\"2024-10-30T18:05:27.3584289Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-21T19:05:27.3584285Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.313539135299997,66.700285598]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-20T19:05:27.3584319Z\",\"lastEdited\":\"2024-10-30T17:05:27.3584320Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-20T19:05:27.3584290Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.425884258750003,66.817857025]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-19T19:05:27.3584325Z\",\"lastEdited\":\"2024-10-30T16:05:27.3584325Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-19T19:05:27.3584322Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.5382293822,66.935428452]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-18T19:05:27.3584329Z\",\"lastEdited\":\"2024-10-30T15:05:27.3584330Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-18T19:05:27.3584327Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65057450565,67.052999879]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-17T19:05:27.3584335Z\",\"lastEdited\":\"2024-10-30T14:05:27.3584335Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-17T19:05:27.3584332Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.7629196291,67.170571306]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-16T19:05:27.3584340Z\",\"lastEdited\":\"2024-10-30T13:05:27.3584340Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "2024-08-16T19:05:27.3584337Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.875264752550002,67.288142733]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-15T19:05:27.3584345Z\",\"lastEdited\":\"2024-10-30T12:05:27.3584345Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-15T19:05:27.3584342Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.987609876,67.40571416]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-14T19:05:27.3584349Z\",\"lastEdited\":\"2024-10-30T11:05:27.3584350Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-14T19:05:27.3584347Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.09995499945,67.523285587]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-13T19:05:27.3584354Z\",\"lastEdited\":\"2024-10-30T10:05:27.3584355Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-13T19:05:27.3584352Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.2123001229,67.640857014]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-12T19:05:27.3584359Z\",\"lastEdited\":\"2024-10-30T09:05:27.3584360Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-12T19:05:27.3584357Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.324645246350002,67.758428441]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-11T19:05:27.3584364Z\",\"lastEdited\":\"2024-10-30T08:05:27.3584365Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-11T19:05:27.3584362Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.4369903698,67.87599986800001]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-10T19:05:27.3584394Z\",\"lastEdited\":\"2024-10-30T07:05:27.3584395Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "2024-08-10T19:05:27.3584367Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.54933549325,67.993571295]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-09T19:05:27.3584399Z\",\"lastEdited\":\"2024-10-30T06:05:27.3584400Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-09T19:05:27.3584397Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.6616806167,68.111142722]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-08T19:05:27.3584404Z\",\"lastEdited\":\"2024-10-30T05:05:27.3584405Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-08T19:05:27.3584401Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77402574015,68.228714149]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-07T19:05:27.3584409Z\",\"lastEdited\":\"2024-10-30T04:05:27.3584410Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-07T19:05:27.3584406Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.8863708636,68.346285576]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-06T19:05:27.3584414Z\",\"lastEdited\":\"2024-10-30T03:05:27.3584415Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-06T19:05:27.3584411Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998715987049998,68.463857003]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-05T19:05:27.3584419Z\",\"lastEdited\":\"2024-10-30T02:05:27.3584420Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-05T19:05:27.3584417Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.1110611105,68.58142843]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-04T19:05:27.3584425Z\",\"lastEdited\":\"2024-10-30T01:05:27.3584425Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "2024-08-04T19:05:27.3584422Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22340623395,68.698999857]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-03T19:05:27.3584430Z\",\"lastEdited\":\"2024-10-30T00:05:27.3584430Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-03T19:05:27.3584427Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.3357513574,68.816571284]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-02T19:05:27.3584435Z\",\"lastEdited\":\"2024-10-29T23:05:27.3584435Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-02T19:05:27.3584432Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.448096480849998,68.93414271099999]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-01T19:05:27.3584440Z\",\"lastEdited\":\"2024-10-29T22:05:27.3584441Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-01T19:05:27.3584437Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.5604416043,69.051714138]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-07-31T19:05:27.3584463Z\",\"lastEdited\":\"2024-10-29T21:05:27.3584464Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-31T19:05:27.3584442Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.67278672775,69.169285565]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-07-30T19:05:27.3584469Z\",\"lastEdited\":\"2024-10-29T20:05:27.3584470Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-30T19:05:27.3584466Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.7851318512,69.286856992]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-07-29T19:05:27.3584474Z\",\"lastEdited\":\"2024-10-29T19:05:27.3584475Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "2024-07-29T19:05:27.3584472Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89747697465,69.404428419]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-07-28T19:05:27.3584479Z\",\"lastEdited\":\"2024-10-29T18:05:27.3584480Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-28T19:05:27.3584477Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.009822098100003,69.521999846]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-27T19:05:27.3584484Z\",\"lastEdited\":\"2024-10-29T17:05:27.3584485Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-27T19:05:27.3584482Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12216722155,69.639571273]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-26T19:05:27.3584489Z\",\"lastEdited\":\"2024-10-29T16:05:27.3584490Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "2024-07-26T19:05:27.3584487Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234512345,69.7571427]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-25T19:05:27.3584495Z\",\"lastEdited\":\"2024-10-29T15:05:27.3584495Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-25T19:05:27.3584492Z" });
        }
    }
}
