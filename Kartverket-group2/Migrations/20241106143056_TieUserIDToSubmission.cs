using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class TieUserIDToSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Submissions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-05T14:30:55.6523197Z\",\"lastEdited\":\"2024-11-06T13:30:55.6523199Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-05T14:30:55.6523170Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-11-04T14:30:55.6523212Z\",\"lastEdited\":\"2024-11-06T12:30:55.6523212Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "2024-11-04T14:30:55.6523208Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-11-03T14:30:55.6523218Z\",\"lastEdited\":\"2024-11-06T11:30:55.6523218Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "2024-11-03T14:30:55.6523215Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-11-02T14:30:55.6523260Z\",\"lastEdited\":\"2024-11-06T10:30:55.6523260Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "2024-11-02T14:30:55.6523256Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-11-01T14:30:55.6523265Z\",\"lastEdited\":\"2024-11-06T09:30:55.6523266Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-01T14:30:55.6523263Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-31T14:30:55.6523272Z\",\"lastEdited\":\"2024-11-06T08:30:55.6523273Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "2024-10-31T14:30:55.6523269Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-30T14:30:55.6523277Z\",\"lastEdited\":\"2024-11-06T07:30:55.6523278Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-30T14:30:55.6523275Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-29T14:30:55.6523283Z\",\"lastEdited\":\"2024-11-06T06:30:55.6523283Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-29T14:30:55.6523280Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-28T14:30:55.6523288Z\",\"lastEdited\":\"2024-11-06T05:30:55.6523289Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-28T14:30:55.6523285Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-27T14:30:55.6523294Z\",\"lastEdited\":\"2024-11-06T04:30:55.6523295Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-27T14:30:55.6523291Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-26T14:30:55.6523299Z\",\"lastEdited\":\"2024-11-06T03:30:55.6523300Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-26T14:30:55.6523296Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-25T14:30:55.6523304Z\",\"lastEdited\":\"2024-11-06T02:30:55.6523305Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "2024-10-25T14:30:55.6523302Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-24T14:30:55.6523310Z\",\"lastEdited\":\"2024-11-06T01:30:55.6523310Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-24T14:30:55.6523307Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-23T14:30:55.6523343Z\",\"lastEdited\":\"2024-11-06T00:30:55.6523344Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-23T14:30:55.6523340Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-22T14:30:55.6523349Z\",\"lastEdited\":\"2024-11-05T23:30:55.6523349Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-22T14:30:55.6523346Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-21T14:30:55.6523354Z\",\"lastEdited\":\"2024-11-05T22:30:55.6523354Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-21T14:30:55.6523351Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-20T14:30:55.6523359Z\",\"lastEdited\":\"2024-11-05T21:30:55.6523360Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-20T14:30:55.6523356Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-19T14:30:55.6523365Z\",\"lastEdited\":\"2024-11-05T20:30:55.6523366Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "2024-10-19T14:30:55.6523362Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-18T14:30:55.6523370Z\",\"lastEdited\":\"2024-11-05T19:30:55.6523371Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-18T14:30:55.6523367Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-17T14:30:55.6523375Z\",\"lastEdited\":\"2024-11-05T18:30:55.6523376Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-17T14:30:55.6523373Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-16T14:30:55.6523381Z\",\"lastEdited\":\"2024-11-05T17:30:55.6523381Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-16T14:30:55.6523378Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-15T14:30:55.6523386Z\",\"lastEdited\":\"2024-11-05T16:30:55.6523387Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-15T14:30:55.6523383Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-14T14:30:55.6523417Z\",\"lastEdited\":\"2024-11-05T15:30:55.6523418Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-14T14:30:55.6523388Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-13T14:30:55.6523422Z\",\"lastEdited\":\"2024-11-05T14:30:55.6523423Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "2024-10-13T14:30:55.6523420Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-12T14:30:55.6523428Z\",\"lastEdited\":\"2024-11-05T13:30:55.6523428Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-12T14:30:55.6523425Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-11T14:30:55.6523433Z\",\"lastEdited\":\"2024-11-05T12:30:55.6523434Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-11T14:30:55.6523430Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-10T14:30:55.6523438Z\",\"lastEdited\":\"2024-11-05T11:30:55.6523439Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-10T14:30:55.6523436Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-09T14:30:55.6523443Z\",\"lastEdited\":\"2024-11-05T10:30:55.6523444Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-09T14:30:55.6523441Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-08T14:30:55.6523449Z\",\"lastEdited\":\"2024-11-05T09:30:55.6523449Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-08T14:30:55.6523446Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-07T14:30:55.6523454Z\",\"lastEdited\":\"2024-11-05T08:30:55.6523455Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "2024-10-07T14:30:55.6523451Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-06T14:30:55.6523459Z\",\"lastEdited\":\"2024-11-05T07:30:55.6523460Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-06T14:30:55.6523456Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-05T14:30:55.6523464Z\",\"lastEdited\":\"2024-11-05T06:30:55.6523465Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-05T14:30:55.6523462Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-10-04T14:30:55.6523469Z\",\"lastEdited\":\"2024-11-05T05:30:55.6523486Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-04T14:30:55.6523467Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-10-03T14:30:55.6523492Z\",\"lastEdited\":\"2024-11-05T04:30:55.6523493Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-03T14:30:55.6523489Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-10-02T14:30:55.6523498Z\",\"lastEdited\":\"2024-11-05T03:30:55.6523498Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-02T14:30:55.6523495Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-10-01T14:30:55.6523503Z\",\"lastEdited\":\"2024-11-05T02:30:55.6523503Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "2024-10-01T14:30:55.6523500Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-30T14:30:55.6523508Z\",\"lastEdited\":\"2024-11-05T01:30:55.6523509Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-30T14:30:55.6523506Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-29T14:30:55.6523514Z\",\"lastEdited\":\"2024-11-05T00:30:55.6523514Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-29T14:30:55.6523511Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-28T14:30:55.6523519Z\",\"lastEdited\":\"2024-11-04T23:30:55.6523520Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-28T14:30:55.6523516Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-27T14:30:55.6523524Z\",\"lastEdited\":\"2024-11-04T22:30:55.6523525Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-27T14:30:55.6523521Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-26T14:30:55.6523529Z\",\"lastEdited\":\"2024-11-04T21:30:55.6523530Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-26T14:30:55.6523526Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-25T14:30:55.6523534Z\",\"lastEdited\":\"2024-11-04T20:30:55.6523535Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "2024-09-25T14:30:55.6523532Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-24T14:30:55.6523585Z\",\"lastEdited\":\"2024-11-04T19:30:55.6523586Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-24T14:30:55.6523581Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-23T14:30:55.6523591Z\",\"lastEdited\":\"2024-11-04T18:30:55.6523591Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-23T14:30:55.6523588Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-22T14:30:55.6523596Z\",\"lastEdited\":\"2024-11-04T17:30:55.6523596Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-22T14:30:55.6523593Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-21T14:30:55.6523601Z\",\"lastEdited\":\"2024-11-04T16:30:55.6523602Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-21T14:30:55.6523598Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-20T14:30:55.6523606Z\",\"lastEdited\":\"2024-11-04T15:30:55.6523607Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-20T14:30:55.6523603Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-19T14:30:55.6523611Z\",\"lastEdited\":\"2024-11-04T14:30:55.6523612Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "2024-09-19T14:30:55.6523609Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-18T14:30:55.6523616Z\",\"lastEdited\":\"2024-11-04T13:30:55.6523617Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-18T14:30:55.6523614Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-17T14:30:55.6523622Z\",\"lastEdited\":\"2024-11-04T12:30:55.6523622Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-17T14:30:55.6523619Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-16T14:30:55.6523627Z\",\"lastEdited\":\"2024-11-04T11:30:55.6523628Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-16T14:30:55.6523624Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-15T14:30:55.6523633Z\",\"lastEdited\":\"2024-11-04T10:30:55.6523633Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-15T14:30:55.6523630Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-14T14:30:55.6523707Z\",\"lastEdited\":\"2024-11-04T09:30:55.6523708Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-14T14:30:55.6523704Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-13T14:30:55.6523712Z\",\"lastEdited\":\"2024-11-04T08:30:55.6523713Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "2024-09-13T14:30:55.6523710Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-12T14:30:55.6523717Z\",\"lastEdited\":\"2024-11-04T07:30:55.6523718Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-12T14:30:55.6523715Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-11T14:30:55.6523722Z\",\"lastEdited\":\"2024-11-04T06:30:55.6523723Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-11T14:30:55.6523720Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-10T14:30:55.6523728Z\",\"lastEdited\":\"2024-11-04T05:30:55.6523728Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-10T14:30:55.6523725Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-09T14:30:55.6523733Z\",\"lastEdited\":\"2024-11-04T04:30:55.6523734Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-09T14:30:55.6523730Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-08T14:30:55.6523738Z\",\"lastEdited\":\"2024-11-04T03:30:55.6523739Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-08T14:30:55.6523735Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-07T14:30:55.6523743Z\",\"lastEdited\":\"2024-11-04T02:30:55.6523744Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "2024-09-07T14:30:55.6523741Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-06T14:30:55.6523749Z\",\"lastEdited\":\"2024-11-04T01:30:55.6523750Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-06T14:30:55.6523746Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-05T14:30:55.6523754Z\",\"lastEdited\":\"2024-11-04T00:30:55.6523755Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-05T14:30:55.6523751Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-09-04T14:30:55.6523798Z\",\"lastEdited\":\"2024-11-03T23:30:55.6523799Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "2024-09-04T14:30:55.6523795Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-09-03T14:30:55.6523804Z\",\"lastEdited\":\"2024-11-03T22:30:55.6523805Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "2024-09-03T14:30:55.6523801Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-09-02T14:30:55.6523809Z\",\"lastEdited\":\"2024-11-03T21:30:55.6523810Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-09-02T14:30:55.6523807Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-09-01T14:30:55.6523816Z\",\"lastEdited\":\"2024-11-03T20:30:55.6523816Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "2024-09-01T14:30:55.6523813Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-31T14:30:55.6523821Z\",\"lastEdited\":\"2024-11-03T19:30:55.6523822Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-31T14:30:55.6523818Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-30T14:30:55.6523826Z\",\"lastEdited\":\"2024-11-03T18:30:55.6523827Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-30T14:30:55.6523824Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-29T14:30:55.6523832Z\",\"lastEdited\":\"2024-11-03T17:30:55.6523832Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-29T14:30:55.6523829Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-28T14:30:55.6523837Z\",\"lastEdited\":\"2024-11-03T16:30:55.6523837Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-28T14:30:55.6523834Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-27T14:30:55.6523881Z\",\"lastEdited\":\"2024-11-03T15:30:55.6523882Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-27T14:30:55.6523839Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-26T14:30:55.6523887Z\",\"lastEdited\":\"2024-11-03T14:30:55.6523888Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "2024-08-26T14:30:55.6523884Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-25T14:30:55.6523892Z\",\"lastEdited\":\"2024-11-03T13:30:55.6523893Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-25T14:30:55.6523890Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-24T14:30:55.6523898Z\",\"lastEdited\":\"2024-11-03T12:30:55.6523898Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-24T14:30:55.6523895Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-23T14:30:55.6523903Z\",\"lastEdited\":\"2024-11-03T11:30:55.6523904Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-23T14:30:55.6523900Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-22T14:30:55.6523908Z\",\"lastEdited\":\"2024-11-03T10:30:55.6523909Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-22T14:30:55.6523906Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-21T14:30:55.6523914Z\",\"lastEdited\":\"2024-11-03T09:30:55.6523914Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-21T14:30:55.6523911Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-20T14:30:55.6523919Z\",\"lastEdited\":\"2024-11-03T08:30:55.6523920Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "2024-08-20T14:30:55.6523916Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-19T14:30:55.6523924Z\",\"lastEdited\":\"2024-11-03T07:30:55.6523925Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-19T14:30:55.6523922Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-18T14:30:55.6523930Z\",\"lastEdited\":\"2024-11-03T06:30:55.6523930Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-18T14:30:55.6523927Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-17T14:30:55.6523935Z\",\"lastEdited\":\"2024-11-03T05:30:55.6523963Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-17T14:30:55.6523932Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-16T14:30:55.6523968Z\",\"lastEdited\":\"2024-11-03T04:30:55.6523968Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-16T14:30:55.6523965Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-15T14:30:55.6523973Z\",\"lastEdited\":\"2024-11-03T03:30:55.6523974Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-15T14:30:55.6523970Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-14T14:30:55.6523978Z\",\"lastEdited\":\"2024-11-03T02:30:55.6523979Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "2024-08-14T14:30:55.6523976Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-13T14:30:55.6523984Z\",\"lastEdited\":\"2024-11-03T01:30:55.6523984Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-13T14:30:55.6523981Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-12T14:30:55.6523989Z\",\"lastEdited\":\"2024-11-03T00:30:55.6523989Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-12T14:30:55.6523986Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-11T14:30:55.6523994Z\",\"lastEdited\":\"2024-11-02T23:30:55.6523995Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-11T14:30:55.6523991Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-10T14:30:55.6523999Z\",\"lastEdited\":\"2024-11-02T22:30:55.6524000Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-10T14:30:55.6523996Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-09T14:30:55.6524005Z\",\"lastEdited\":\"2024-11-02T21:30:55.6524005Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-09T14:30:55.6524002Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-08T14:30:55.6524010Z\",\"lastEdited\":\"2024-11-02T20:30:55.6524010Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "2024-08-08T14:30:55.6524007Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-07T14:30:55.6524015Z\",\"lastEdited\":\"2024-11-02T19:30:55.6524041Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-07T14:30:55.6524012Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-06T14:30:55.6524046Z\",\"lastEdited\":\"2024-11-02T18:30:55.6524047Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-06T14:30:55.6524043Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-05T14:30:55.6524051Z\",\"lastEdited\":\"2024-11-02T17:30:55.6524052Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "2024-08-05T14:30:55.6524049Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-08-04T14:30:55.6524057Z\",\"lastEdited\":\"2024-11-02T16:30:55.6524057Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "2024-08-04T14:30:55.6524054Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-08-03T14:30:55.6524062Z\",\"lastEdited\":\"2024-11-02T15:30:55.6524063Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-03T14:30:55.6524059Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-08-02T14:30:55.6524067Z\",\"lastEdited\":\"2024-11-02T14:30:55.6524068Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "2024-08-02T14:30:55.6524065Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-08-01T14:30:55.6524073Z\",\"lastEdited\":\"2024-11-02T13:30:55.6524073Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-08-01T14:30:55.6524070Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-31T14:30:55.6524078Z\",\"lastEdited\":\"2024-11-02T12:30:55.6524078Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-31T14:30:55.6524075Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-30T14:30:55.6524083Z\",\"lastEdited\":\"2024-11-02T11:30:55.6524084Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "2024-07-30T14:30:55.6524080Z", null });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Timestamp", "UserId" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-29T14:30:55.6524089Z\",\"lastEdited\":\"2024-11-02T10:30:55.6524090Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "2024-07-29T14:30:55.6524086Z", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Submissions");

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
    }
}
