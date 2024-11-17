using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-02T15:03:07.0423851Z\",\"lastEdited\":\"2024-11-03T14:03:07.0423852Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-02T15:03:07.0423815Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-11-01T15:03:07.0423863Z\",\"lastEdited\":\"2024-11-03T13:03:07.0423863Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "2024-11-01T15:03:07.0423859Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-31T15:03:07.0423868Z\",\"lastEdited\":\"2024-11-03T12:03:07.0423869Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-31T15:03:07.0423866Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-30T15:03:07.0423875Z\",\"lastEdited\":\"2024-11-03T11:03:07.0423876Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-30T15:03:07.0423872Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-29T15:03:07.0423880Z\",\"lastEdited\":\"2024-11-03T10:03:07.0423881Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-29T15:03:07.0423878Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-28T15:03:07.0423932Z\",\"lastEdited\":\"2024-11-03T09:03:07.0423934Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "2024-10-28T15:03:07.0423885Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-27T15:03:07.0423940Z\",\"lastEdited\":\"2024-11-03T08:03:07.0423941Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-27T15:03:07.0423937Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-26T15:03:07.0423946Z\",\"lastEdited\":\"2024-11-03T07:03:07.0423947Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-26T15:03:07.0423943Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-25T15:03:07.0423952Z\",\"lastEdited\":\"2024-11-03T06:03:07.0423952Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-25T15:03:07.0423949Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-24T15:03:07.0423959Z\",\"lastEdited\":\"2024-11-03T05:03:07.0423959Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-24T15:03:07.0423956Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-23T15:03:07.0423964Z\",\"lastEdited\":\"2024-11-03T04:03:07.0423965Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-23T15:03:07.0423961Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-22T15:03:07.0423970Z\",\"lastEdited\":\"2024-11-03T03:03:07.0423971Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "2024-10-22T15:03:07.0423967Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-21T15:03:07.0423976Z\",\"lastEdited\":\"2024-11-03T02:03:07.0423977Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-21T15:03:07.0423973Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-20T15:03:07.0423982Z\",\"lastEdited\":\"2024-11-03T01:03:07.0423983Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-20T15:03:07.0423979Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-19T15:03:07.0423988Z\",\"lastEdited\":\"2024-11-03T00:03:07.0423989Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-19T15:03:07.0423985Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-18T15:03:07.0424038Z\",\"lastEdited\":\"2024-11-02T23:03:07.0424039Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-18T15:03:07.0423991Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-17T15:03:07.0424044Z\",\"lastEdited\":\"2024-11-02T22:03:07.0424045Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-17T15:03:07.0424041Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-16T15:03:07.0424050Z\",\"lastEdited\":\"2024-11-02T21:03:07.0424051Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "2024-10-16T15:03:07.0424047Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-15T15:03:07.0424056Z\",\"lastEdited\":\"2024-11-02T20:03:07.0424057Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-15T15:03:07.0424053Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-14T15:03:07.0424062Z\",\"lastEdited\":\"2024-11-02T19:03:07.0424063Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-14T15:03:07.0424059Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-13T15:03:07.0424068Z\",\"lastEdited\":\"2024-11-02T18:03:07.0424069Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-13T15:03:07.0424065Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-12T15:03:07.0424074Z\",\"lastEdited\":\"2024-11-02T17:03:07.0424075Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-12T15:03:07.0424071Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-11T15:03:07.0424079Z\",\"lastEdited\":\"2024-11-02T16:03:07.0424080Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-11T15:03:07.0424077Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-10T15:03:07.0424085Z\",\"lastEdited\":\"2024-11-02T15:03:07.0424086Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "2024-10-10T15:03:07.0424082Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-09T15:03:07.0424091Z\",\"lastEdited\":\"2024-11-02T14:03:07.0424092Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-09T15:03:07.0424088Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-08T15:03:07.0424133Z\",\"lastEdited\":\"2024-11-02T13:03:07.0424134Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-08T15:03:07.0424094Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-07T15:03:07.0424140Z\",\"lastEdited\":\"2024-11-02T12:03:07.0424141Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-07T15:03:07.0424137Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-06T15:03:07.0424146Z\",\"lastEdited\":\"2024-11-02T11:03:07.0424147Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-06T15:03:07.0424143Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-05T15:03:07.0424151Z\",\"lastEdited\":\"2024-11-02T10:03:07.0424152Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-05T15:03:07.0424149Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-04T15:03:07.0424157Z\",\"lastEdited\":\"2024-11-02T09:03:07.0424158Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "2024-10-04T15:03:07.0424154Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-03T15:03:07.0424163Z\",\"lastEdited\":\"2024-11-02T08:03:07.0424164Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-03T15:03:07.0424160Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-02T15:03:07.0424169Z\",\"lastEdited\":\"2024-11-02T07:03:07.0424170Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-02T15:03:07.0424166Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-10-01T15:03:07.0424174Z\",\"lastEdited\":\"2024-11-02T06:03:07.0424175Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-01T15:03:07.0424171Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-09-30T15:03:07.0424181Z\",\"lastEdited\":\"2024-11-02T05:03:07.0424181Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-30T15:03:07.0424178Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-09-29T15:03:07.0424186Z\",\"lastEdited\":\"2024-11-02T04:03:07.0424187Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-29T15:03:07.0424183Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-09-28T15:03:07.0424218Z\",\"lastEdited\":\"2024-11-02T03:03:07.0424219Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "2024-09-28T15:03:07.0424214Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-27T15:03:07.0424224Z\",\"lastEdited\":\"2024-11-02T02:03:07.0424225Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-27T15:03:07.0424221Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-26T15:03:07.0424230Z\",\"lastEdited\":\"2024-11-02T01:03:07.0424231Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-26T15:03:07.0424227Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-25T15:03:07.0424236Z\",\"lastEdited\":\"2024-11-02T00:03:07.0424237Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-25T15:03:07.0424233Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-24T15:03:07.0424242Z\",\"lastEdited\":\"2024-11-01T23:03:07.0424243Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-24T15:03:07.0424239Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-23T15:03:07.0424248Z\",\"lastEdited\":\"2024-11-01T22:03:07.0424249Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-23T15:03:07.0424245Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-22T15:03:07.0424254Z\",\"lastEdited\":\"2024-11-01T21:03:07.0424255Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "2024-09-22T15:03:07.0424251Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-21T15:03:07.0424259Z\",\"lastEdited\":\"2024-11-01T20:03:07.0424260Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-21T15:03:07.0424256Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-20T15:03:07.0424265Z\",\"lastEdited\":\"2024-11-01T19:03:07.0424266Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-20T15:03:07.0424262Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-19T15:03:07.0424271Z\",\"lastEdited\":\"2024-11-01T18:03:07.0424272Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-19T15:03:07.0424268Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-18T15:03:07.0424306Z\",\"lastEdited\":\"2024-11-01T17:03:07.0424307Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-18T15:03:07.0424303Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-17T15:03:07.0424312Z\",\"lastEdited\":\"2024-11-01T16:03:07.0424313Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-17T15:03:07.0424309Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-16T15:03:07.0424318Z\",\"lastEdited\":\"2024-11-01T15:03:07.0424318Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "2024-09-16T15:03:07.0424315Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-15T15:03:07.0424323Z\",\"lastEdited\":\"2024-11-01T14:03:07.0424324Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-15T15:03:07.0424320Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-14T15:03:07.0424329Z\",\"lastEdited\":\"2024-11-01T13:03:07.0424329Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-14T15:03:07.0424326Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-13T15:03:07.0424334Z\",\"lastEdited\":\"2024-11-01T12:03:07.0424335Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-13T15:03:07.0424331Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-12T15:03:07.0424340Z\",\"lastEdited\":\"2024-11-01T11:03:07.0424341Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-12T15:03:07.0424337Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-11T15:03:07.0424346Z\",\"lastEdited\":\"2024-11-01T10:03:07.0424347Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-11T15:03:07.0424343Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-10T15:03:07.0424352Z\",\"lastEdited\":\"2024-11-01T09:03:07.0424352Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "2024-09-10T15:03:07.0424349Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-09T15:03:07.0424357Z\",\"lastEdited\":\"2024-11-01T08:03:07.0424358Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-09T15:03:07.0424354Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-08T15:03:07.0424380Z\",\"lastEdited\":\"2024-11-01T07:03:07.0424380Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-08T15:03:07.0424360Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-07T15:03:07.0424386Z\",\"lastEdited\":\"2024-11-01T06:03:07.0424387Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-07T15:03:07.0424383Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-06T15:03:07.0424392Z\",\"lastEdited\":\"2024-11-01T05:03:07.0424392Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-06T15:03:07.0424389Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-05T15:03:07.0424397Z\",\"lastEdited\":\"2024-11-01T04:03:07.0424398Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-05T15:03:07.0424394Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-04T15:03:07.0424403Z\",\"lastEdited\":\"2024-11-01T03:03:07.0424404Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "2024-09-04T15:03:07.0424400Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-03T15:03:07.0424409Z\",\"lastEdited\":\"2024-11-01T02:03:07.0424410Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-03T15:03:07.0424406Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-02T15:03:07.0424414Z\",\"lastEdited\":\"2024-11-01T01:03:07.0424415Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-02T15:03:07.0424412Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-09-01T15:03:07.0424420Z\",\"lastEdited\":\"2024-11-01T00:03:07.0424421Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-01T15:03:07.0424417Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-08-31T15:03:07.0424425Z\",\"lastEdited\":\"2024-10-31T23:03:07.0424426Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-31T15:03:07.0424423Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-08-30T15:03:07.0424431Z\",\"lastEdited\":\"2024-10-31T22:03:07.0424432Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-30T15:03:07.0424428Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-08-29T15:03:07.0424482Z\",\"lastEdited\":\"2024-10-31T21:03:07.0424483Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "2024-08-29T15:03:07.0424479Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-28T15:03:07.0424488Z\",\"lastEdited\":\"2024-10-31T20:03:07.0424489Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-28T15:03:07.0424485Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-27T15:03:07.0424494Z\",\"lastEdited\":\"2024-10-31T19:03:07.0424494Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-27T15:03:07.0424491Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-26T15:03:07.0424499Z\",\"lastEdited\":\"2024-10-31T18:03:07.0424500Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-26T15:03:07.0424496Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-25T15:03:07.0424505Z\",\"lastEdited\":\"2024-10-31T17:03:07.0424506Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-25T15:03:07.0424502Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-24T15:03:07.0424510Z\",\"lastEdited\":\"2024-10-31T16:03:07.0424511Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-24T15:03:07.0424507Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-23T15:03:07.0424516Z\",\"lastEdited\":\"2024-10-31T15:03:07.0424517Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "2024-08-23T15:03:07.0424513Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-22T15:03:07.0424522Z\",\"lastEdited\":\"2024-10-31T14:03:07.0424523Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-22T15:03:07.0424519Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-21T15:03:07.0424527Z\",\"lastEdited\":\"2024-10-31T13:03:07.0424528Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-21T15:03:07.0424525Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-20T15:03:07.0424589Z\",\"lastEdited\":\"2024-10-31T12:03:07.0424590Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-20T15:03:07.0424586Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-19T15:03:07.0424595Z\",\"lastEdited\":\"2024-10-31T11:03:07.0424596Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-19T15:03:07.0424592Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-18T15:03:07.0424601Z\",\"lastEdited\":\"2024-10-31T10:03:07.0424601Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-18T15:03:07.0424598Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-17T15:03:07.0424606Z\",\"lastEdited\":\"2024-10-31T09:03:07.0424607Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "2024-08-17T15:03:07.0424603Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-16T15:03:07.0424612Z\",\"lastEdited\":\"2024-10-31T08:03:07.0424613Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-16T15:03:07.0424609Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-15T15:03:07.0424617Z\",\"lastEdited\":\"2024-10-31T07:03:07.0424618Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-15T15:03:07.0424615Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-14T15:03:07.0424623Z\",\"lastEdited\":\"2024-10-31T06:03:07.0424624Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-14T15:03:07.0424620Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-13T15:03:07.0424629Z\",\"lastEdited\":\"2024-10-31T05:03:07.0424630Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-13T15:03:07.0424626Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-12T15:03:07.0424635Z\",\"lastEdited\":\"2024-10-31T04:03:07.0424636Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-12T15:03:07.0424632Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-11T15:03:07.0424640Z\",\"lastEdited\":\"2024-10-31T03:03:07.0424641Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "2024-08-11T15:03:07.0424638Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-10T15:03:07.0424674Z\",\"lastEdited\":\"2024-10-31T02:03:07.0424675Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-10T15:03:07.0424671Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-09T15:03:07.0424680Z\",\"lastEdited\":\"2024-10-31T01:03:07.0424681Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-09T15:03:07.0424677Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-08T15:03:07.0424686Z\",\"lastEdited\":\"2024-10-31T00:03:07.0424687Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-08T15:03:07.0424683Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-07T15:03:07.0424692Z\",\"lastEdited\":\"2024-10-30T23:03:07.0424693Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-07T15:03:07.0424689Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-06T15:03:07.0424697Z\",\"lastEdited\":\"2024-10-30T22:03:07.0424698Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-06T15:03:07.0424695Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-05T15:03:07.0424703Z\",\"lastEdited\":\"2024-10-30T21:03:07.0424704Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "2024-08-05T15:03:07.0424700Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-04T15:03:07.0424709Z\",\"lastEdited\":\"2024-10-30T20:03:07.0424710Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-04T15:03:07.0424706Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-03T15:03:07.0424715Z\",\"lastEdited\":\"2024-10-30T19:03:07.0424716Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-03T15:03:07.0424712Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-02T15:03:07.0424720Z\",\"lastEdited\":\"2024-10-30T18:03:07.0424721Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-02T15:03:07.0424717Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-08-01T15:03:07.0424726Z\",\"lastEdited\":\"2024-10-30T17:03:07.0424727Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-01T15:03:07.0424723Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-07-31T15:03:07.0424758Z\",\"lastEdited\":\"2024-10-30T16:03:07.0424759Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-31T15:03:07.0424729Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-07-30T15:03:07.0424764Z\",\"lastEdited\":\"2024-10-30T15:03:07.0424765Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "2024-07-30T15:03:07.0424761Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-07-29T15:03:07.0424770Z\",\"lastEdited\":\"2024-10-30T14:03:07.0424771Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-07-29T15:03:07.0424767Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-28T15:03:07.0424776Z\",\"lastEdited\":\"2024-10-30T13:03:07.0424776Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-28T15:03:07.0424773Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-27T15:03:07.0424781Z\",\"lastEdited\":\"2024-10-30T12:03:07.0424782Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "2024-07-27T15:03:07.0424778Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-26T15:03:07.0424787Z\",\"lastEdited\":\"2024-10-30T11:03:07.0424788Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-26T15:03:07.0424784Z" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
