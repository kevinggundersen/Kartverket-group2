using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminCommentToSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminComment",
                table: "Submissions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-07T12:31:13.8217109Z\",\"lastEdited\":\"2024-11-08T11:31:13.8217111Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-11-07T12:31:13.8217070Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-11-06T12:31:13.8217121Z\",\"lastEdited\":\"2024-11-08T10:31:13.8217122Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-11-06T12:31:13.8217117Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-11-05T12:31:13.8217128Z\",\"lastEdited\":\"2024-11-08T09:31:13.8217128Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-11-05T12:31:13.8217124Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-11-04T12:31:13.8217134Z\",\"lastEdited\":\"2024-11-08T08:31:13.8217135Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-11-04T12:31:13.8217131Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-11-03T12:31:13.8217139Z\",\"lastEdited\":\"2024-11-08T07:31:13.8217140Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-11-03T12:31:13.8217136Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-11-02T12:31:13.8217146Z\",\"lastEdited\":\"2024-11-08T06:31:13.8217147Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-11-02T12:31:13.8217143Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-11-01T12:31:13.8217170Z\",\"lastEdited\":\"2024-11-08T05:31:13.8217170Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-11-01T12:31:13.8217149Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-31T12:31:13.8217175Z\",\"lastEdited\":\"2024-11-08T04:31:13.8217176Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-31T12:31:13.8217172Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-30T12:31:13.8217180Z\",\"lastEdited\":\"2024-11-08T03:31:13.8217181Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-30T12:31:13.8217178Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-29T12:31:13.8217187Z\",\"lastEdited\":\"2024-11-08T02:31:13.8217188Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-29T12:31:13.8217184Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-28T12:31:13.8217192Z\",\"lastEdited\":\"2024-11-08T01:31:13.8217193Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-28T12:31:13.8217189Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-27T12:31:13.8217198Z\",\"lastEdited\":\"2024-11-08T00:31:13.8217198Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-27T12:31:13.8217195Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-26T12:31:13.8217204Z\",\"lastEdited\":\"2024-11-07T23:31:13.8217204Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-26T12:31:13.8217200Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-25T12:31:13.8217208Z\",\"lastEdited\":\"2024-11-07T22:31:13.8217209Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-25T12:31:13.8217206Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-24T12:31:13.8217212Z\",\"lastEdited\":\"2024-11-07T21:31:13.8217213Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-24T12:31:13.8217210Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-23T12:31:13.8217216Z\",\"lastEdited\":\"2024-11-07T20:31:13.8217217Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-23T12:31:13.8217214Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-22T12:31:13.8217261Z\",\"lastEdited\":\"2024-11-07T19:31:13.8217262Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-22T12:31:13.8217259Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-21T12:31:13.8217267Z\",\"lastEdited\":\"2024-11-07T18:31:13.8217268Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-21T12:31:13.8217265Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-20T12:31:13.8217273Z\",\"lastEdited\":\"2024-11-07T17:31:13.8217274Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-20T12:31:13.8217270Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-19T12:31:13.8217279Z\",\"lastEdited\":\"2024-11-07T16:31:13.8217279Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-19T12:31:13.8217276Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-18T12:31:13.8217284Z\",\"lastEdited\":\"2024-11-07T15:31:13.8217284Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-18T12:31:13.8217281Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-17T12:31:13.8217288Z\",\"lastEdited\":\"2024-11-07T14:31:13.8217289Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-17T12:31:13.8217286Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-16T12:31:13.8217293Z\",\"lastEdited\":\"2024-11-07T13:31:13.8217293Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-16T12:31:13.8217291Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-15T12:31:13.8217297Z\",\"lastEdited\":\"2024-11-07T12:31:13.8217298Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-15T12:31:13.8217295Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-14T12:31:13.8217301Z\",\"lastEdited\":\"2024-11-07T11:31:13.8217301Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-14T12:31:13.8217299Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-13T12:31:13.8217347Z\",\"lastEdited\":\"2024-11-07T10:31:13.8217348Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-13T12:31:13.8217303Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-12T12:31:13.8217353Z\",\"lastEdited\":\"2024-11-07T09:31:13.8217353Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-12T12:31:13.8217350Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-11T12:31:13.8217357Z\",\"lastEdited\":\"2024-11-07T08:31:13.8217358Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-11T12:31:13.8217355Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-10T12:31:13.8217362Z\",\"lastEdited\":\"2024-11-07T07:31:13.8217363Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-10T12:31:13.8217360Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-09T12:31:13.8217366Z\",\"lastEdited\":\"2024-11-07T06:31:13.8217367Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-09T12:31:13.8217364Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-08T12:31:13.8217370Z\",\"lastEdited\":\"2024-11-07T05:31:13.8217371Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-08T12:31:13.8217368Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-07T12:31:13.8217374Z\",\"lastEdited\":\"2024-11-07T04:31:13.8217375Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-07T12:31:13.8217372Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-10-06T12:31:13.8217378Z\",\"lastEdited\":\"2024-11-07T03:31:13.8217379Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-06T12:31:13.8217376Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-10-05T12:31:13.8217384Z\",\"lastEdited\":\"2024-11-07T02:31:13.8217384Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-05T12:31:13.8217382Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-10-04T12:31:13.8217387Z\",\"lastEdited\":\"2024-11-07T01:31:13.8217388Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-04T12:31:13.8217386Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-10-03T12:31:13.8217409Z\",\"lastEdited\":\"2024-11-07T00:31:13.8217410Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-10-03T12:31:13.8217407Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-10-02T12:31:13.8217414Z\",\"lastEdited\":\"2024-11-06T23:31:13.8217414Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-10-02T12:31:13.8217412Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-10-01T12:31:13.8217418Z\",\"lastEdited\":\"2024-11-06T22:31:13.8217419Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-10-01T12:31:13.8217416Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-30T12:31:13.8217422Z\",\"lastEdited\":\"2024-11-06T21:31:13.8217423Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-30T12:31:13.8217420Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-29T12:31:13.8217426Z\",\"lastEdited\":\"2024-11-06T20:31:13.8217427Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-29T12:31:13.8217424Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-28T12:31:13.8217431Z\",\"lastEdited\":\"2024-11-06T19:31:13.8217431Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-28T12:31:13.8217428Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-27T12:31:13.8217435Z\",\"lastEdited\":\"2024-11-06T18:31:13.8217435Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-27T12:31:13.8217433Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-26T12:31:13.8217438Z\",\"lastEdited\":\"2024-11-06T17:31:13.8217439Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-26T12:31:13.8217437Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-25T12:31:13.8217442Z\",\"lastEdited\":\"2024-11-06T16:31:13.8217443Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-25T12:31:13.8217440Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-24T12:31:13.8217479Z\",\"lastEdited\":\"2024-11-06T15:31:13.8217480Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-24T12:31:13.8217444Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-23T12:31:13.8217484Z\",\"lastEdited\":\"2024-11-06T14:31:13.8217485Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-23T12:31:13.8217482Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-22T12:31:13.8217489Z\",\"lastEdited\":\"2024-11-06T13:31:13.8217489Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-22T12:31:13.8217487Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-21T12:31:13.8217493Z\",\"lastEdited\":\"2024-11-06T12:31:13.8217494Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-21T12:31:13.8217491Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-20T12:31:13.8217498Z\",\"lastEdited\":\"2024-11-06T11:31:13.8217498Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-20T12:31:13.8217496Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-19T12:31:13.8217502Z\",\"lastEdited\":\"2024-11-06T10:31:13.8217503Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-19T12:31:13.8217500Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-18T12:31:13.8217507Z\",\"lastEdited\":\"2024-11-06T09:31:13.8217507Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-18T12:31:13.8217504Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-17T12:31:13.8217511Z\",\"lastEdited\":\"2024-11-06T08:31:13.8217512Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-17T12:31:13.8217509Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-16T12:31:13.8217516Z\",\"lastEdited\":\"2024-11-06T07:31:13.8217517Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-16T12:31:13.8217513Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-15T12:31:13.8217520Z\",\"lastEdited\":\"2024-11-06T06:31:13.8217520Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-15T12:31:13.8217518Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-14T12:31:13.8217561Z\",\"lastEdited\":\"2024-11-06T05:31:13.8217562Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-14T12:31:13.8217522Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-13T12:31:13.8217566Z\",\"lastEdited\":\"2024-11-06T04:31:13.8217567Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-13T12:31:13.8217564Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-12T12:31:13.8217571Z\",\"lastEdited\":\"2024-11-06T03:31:13.8217571Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-12T12:31:13.8217568Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-11T12:31:13.8217575Z\",\"lastEdited\":\"2024-11-06T02:31:13.8217576Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-11T12:31:13.8217573Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-10T12:31:13.8217580Z\",\"lastEdited\":\"2024-11-06T01:31:13.8217580Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-10T12:31:13.8217578Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-09T12:31:13.8217584Z\",\"lastEdited\":\"2024-11-06T00:31:13.8217585Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-09T12:31:13.8217582Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-08T12:31:13.8217588Z\",\"lastEdited\":\"2024-11-05T23:31:13.8217589Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-08T12:31:13.8217586Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-07T12:31:13.8217592Z\",\"lastEdited\":\"2024-11-05T22:31:13.8217593Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-07T12:31:13.8217590Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-09-06T12:31:13.8217596Z\",\"lastEdited\":\"2024-11-05T21:31:13.8217597Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-06T12:31:13.8217594Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-09-05T12:31:13.8217601Z\",\"lastEdited\":\"2024-11-05T20:31:13.8217602Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-05T12:31:13.8217599Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-09-04T12:31:13.8217632Z\",\"lastEdited\":\"2024-11-05T19:31:13.8217633Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-04T12:31:13.8217603Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-09-03T12:31:13.8217638Z\",\"lastEdited\":\"2024-11-05T18:31:13.8217639Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-09-03T12:31:13.8217636Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-09-02T12:31:13.8217643Z\",\"lastEdited\":\"2024-11-05T17:31:13.8217643Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-09-02T12:31:13.8217640Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-09-01T12:31:13.8217647Z\",\"lastEdited\":\"2024-11-05T16:31:13.8217647Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-09-01T12:31:13.8217645Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-31T12:31:13.8217652Z\",\"lastEdited\":\"2024-11-05T15:31:13.8217652Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-31T12:31:13.8217649Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-30T12:31:13.8217656Z\",\"lastEdited\":\"2024-11-05T14:31:13.8217656Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-30T12:31:13.8217654Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-29T12:31:13.8217660Z\",\"lastEdited\":\"2024-11-05T13:31:13.8217660Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-29T12:31:13.8217658Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-28T12:31:13.8217664Z\",\"lastEdited\":\"2024-11-05T12:31:13.8217665Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-28T12:31:13.8217662Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-27T12:31:13.8217668Z\",\"lastEdited\":\"2024-11-05T11:31:13.8217669Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-27T12:31:13.8217666Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-26T12:31:13.8217699Z\",\"lastEdited\":\"2024-11-05T10:31:13.8217700Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-26T12:31:13.8217696Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-25T12:31:13.8217704Z\",\"lastEdited\":\"2024-11-05T09:31:13.8217704Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-25T12:31:13.8217701Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-24T12:31:13.8217708Z\",\"lastEdited\":\"2024-11-05T08:31:13.8217709Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-24T12:31:13.8217706Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-23T12:31:13.8217713Z\",\"lastEdited\":\"2024-11-05T07:31:13.8217714Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-23T12:31:13.8217711Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-22T12:31:13.8217718Z\",\"lastEdited\":\"2024-11-05T06:31:13.8217718Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-22T12:31:13.8217715Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-21T12:31:13.8217722Z\",\"lastEdited\":\"2024-11-05T05:31:13.8217723Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-21T12:31:13.8217720Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-20T12:31:13.8217727Z\",\"lastEdited\":\"2024-11-05T04:31:13.8217727Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-20T12:31:13.8217724Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-19T12:31:13.8217731Z\",\"lastEdited\":\"2024-11-05T03:31:13.8217732Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-19T12:31:13.8217728Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-18T12:31:13.8217735Z\",\"lastEdited\":\"2024-11-05T02:31:13.8217736Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-18T12:31:13.8217733Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-17T12:31:13.8217740Z\",\"lastEdited\":\"2024-11-05T01:31:13.8217740Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-17T12:31:13.8217737Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-16T12:31:13.8217774Z\",\"lastEdited\":\"2024-11-05T00:31:13.8217775Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-16T12:31:13.8217771Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-15T12:31:13.8217779Z\",\"lastEdited\":\"2024-11-04T23:31:13.8217780Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-15T12:31:13.8217777Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-14T12:31:13.8217784Z\",\"lastEdited\":\"2024-11-04T22:31:13.8217784Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-14T12:31:13.8217781Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-13T12:31:13.8217788Z\",\"lastEdited\":\"2024-11-04T21:31:13.8217789Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-13T12:31:13.8217786Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-12T12:31:13.8217792Z\",\"lastEdited\":\"2024-11-04T20:31:13.8217793Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-12T12:31:13.8217790Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-11T12:31:13.8217797Z\",\"lastEdited\":\"2024-11-04T19:31:13.8217797Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-11T12:31:13.8217794Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-10T12:31:13.8217801Z\",\"lastEdited\":\"2024-11-04T18:31:13.8217801Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-10T12:31:13.8217799Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-09T12:31:13.8217805Z\",\"lastEdited\":\"2024-11-04T17:31:13.8217805Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-09T12:31:13.8217803Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-08T12:31:13.8217809Z\",\"lastEdited\":\"2024-11-04T16:31:13.8217810Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-08T12:31:13.8217807Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-07T12:31:13.8217813Z\",\"lastEdited\":\"2024-11-04T15:31:13.8217814Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-07T12:31:13.8217811Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-08-06T12:31:13.8217844Z\",\"lastEdited\":\"2024-11-04T14:31:13.8217844Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-06T12:31:13.8217841Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-08-05T12:31:13.8217849Z\",\"lastEdited\":\"2024-11-04T13:31:13.8217850Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-05T12:31:13.8217846Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-08-04T12:31:13.8217855Z\",\"lastEdited\":\"2024-11-04T12:31:13.8217855Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-04T12:31:13.8217852Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-08-03T12:31:13.8217859Z\",\"lastEdited\":\"2024-11-04T11:31:13.8217860Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Ikke påbegynt", "2024-08-03T12:31:13.8217857Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-08-02T12:31:13.8217863Z\",\"lastEdited\":\"2024-11-04T10:31:13.8217864Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-08-02T12:31:13.8217861Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-08-01T12:31:13.8217868Z\",\"lastEdited\":\"2024-11-04T09:31:13.8217869Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "Behandlet", "2024-08-01T12:31:13.8217866Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AdminComment", "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { null, "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-31T12:31:13.8217873Z\",\"lastEdited\":\"2024-11-04T08:31:13.8217874Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "Under behandling", "2024-07-31T12:31:13.8217870Z" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminComment",
                table: "Submissions");

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234,58.11757]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-05T14:30:55.6523197Z\",\"lastEdited\":\"2024-11-06T13:30:55.6523199Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-11-05T14:30:55.6523170Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.22468,58.23514]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-11-04T14:30:55.6523212Z\",\"lastEdited\":\"2024-11-06T12:30:55.6523212Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-11-04T14:30:55.6523208Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33702,58.35271]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-11-03T14:30:55.6523218Z\",\"lastEdited\":\"2024-11-06T11:30:55.6523218Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-11-03T14:30:55.6523215Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.44936,58.47028]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-11-02T14:30:55.6523260Z\",\"lastEdited\":\"2024-11-06T10:30:55.6523260Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-11-02T14:30:55.6523256Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.5617,58.58785]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-11-01T14:30:55.6523265Z\",\"lastEdited\":\"2024-11-06T09:30:55.6523266Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-11-01T14:30:55.6523263Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.67404,58.70542]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-31T14:30:55.6523272Z\",\"lastEdited\":\"2024-11-06T08:30:55.6523273Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-31T14:30:55.6523269Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78638,58.82299]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-30T14:30:55.6523277Z\",\"lastEdited\":\"2024-11-06T07:30:55.6523278Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-30T14:30:55.6523275Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.89872,58.94056]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-29T14:30:55.6523283Z\",\"lastEdited\":\"2024-11-06T06:30:55.6523283Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-29T14:30:55.6523280Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01106,59.05813]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-28T14:30:55.6523288Z\",\"lastEdited\":\"2024-11-06T05:30:55.6523289Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-28T14:30:55.6523285Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234,59.1757]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-27T14:30:55.6523294Z\",\"lastEdited\":\"2024-11-06T04:30:55.6523295Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-27T14:30:55.6523291Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23574,59.29327]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-26T14:30:55.6523299Z\",\"lastEdited\":\"2024-11-06T03:30:55.6523300Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-26T14:30:55.6523296Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.34808,59.41084]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-25T14:30:55.6523304Z\",\"lastEdited\":\"2024-11-06T02:30:55.6523305Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-25T14:30:55.6523302Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46042,59.52841]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-24T14:30:55.6523310Z\",\"lastEdited\":\"2024-11-06T01:30:55.6523310Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-24T14:30:55.6523307Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.57276,59.64598]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-23T14:30:55.6523343Z\",\"lastEdited\":\"2024-11-06T00:30:55.6523344Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-23T14:30:55.6523340Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.6851,59.76355]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-22T14:30:55.6523349Z\",\"lastEdited\":\"2024-11-05T23:30:55.6523349Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-22T14:30:55.6523346Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.79744,59.88112]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-21T14:30:55.6523354Z\",\"lastEdited\":\"2024-11-05T22:30:55.6523354Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-21T14:30:55.6523351Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90978,59.998689999999996]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-20T14:30:55.6523359Z\",\"lastEdited\":\"2024-11-05T21:30:55.6523360Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-20T14:30:55.6523356Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.022120000000001,60.11626]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-19T14:30:55.6523365Z\",\"lastEdited\":\"2024-11-05T20:30:55.6523366Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-19T14:30:55.6523362Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13446,60.23383]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-18T14:30:55.6523370Z\",\"lastEdited\":\"2024-11-05T19:30:55.6523371Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-18T14:30:55.6523367Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2468,60.3514]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-17T14:30:55.6523375Z\",\"lastEdited\":\"2024-11-05T18:30:55.6523376Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-17T14:30:55.6523373Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35914,60.46897]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-16T14:30:55.6523381Z\",\"lastEdited\":\"2024-11-05T17:30:55.6523381Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-16T14:30:55.6523378Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.47148,60.58654]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-15T14:30:55.6523386Z\",\"lastEdited\":\"2024-11-05T16:30:55.6523387Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-15T14:30:55.6523383Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58382,60.70411]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-14T14:30:55.6523417Z\",\"lastEdited\":\"2024-11-05T15:30:55.6523418Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-14T14:30:55.6523388Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.696159999999999,60.82168]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-13T14:30:55.6523422Z\",\"lastEdited\":\"2024-11-05T14:30:55.6523423Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-13T14:30:55.6523420Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8085,60.93925]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-12T14:30:55.6523428Z\",\"lastEdited\":\"2024-11-05T13:30:55.6523428Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-12T14:30:55.6523425Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.92084,61.05682]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-11T14:30:55.6523433Z\",\"lastEdited\":\"2024-11-05T12:30:55.6523434Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-11T14:30:55.6523430Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03318,61.17439]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-10T14:30:55.6523438Z\",\"lastEdited\":\"2024-11-05T11:30:55.6523439Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-10T14:30:55.6523436Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.14552,61.29196]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-09T14:30:55.6523443Z\",\"lastEdited\":\"2024-11-05T10:30:55.6523444Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-09T14:30:55.6523441Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25786,61.40953]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-08T14:30:55.6523449Z\",\"lastEdited\":\"2024-11-05T09:30:55.6523449Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-08T14:30:55.6523446Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.3702,61.5271]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-07T14:30:55.6523454Z\",\"lastEdited\":\"2024-11-05T08:30:55.6523455Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-07T14:30:55.6523451Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48254,61.64467]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-06T14:30:55.6523459Z\",\"lastEdited\":\"2024-11-05T07:30:55.6523460Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-06T14:30:55.6523456Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.59488,61.76224]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-05T14:30:55.6523464Z\",\"lastEdited\":\"2024-11-05T06:30:55.6523465Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-05T14:30:55.6523462Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.70722,61.87981]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-10-04T14:30:55.6523469Z\",\"lastEdited\":\"2024-11-05T05:30:55.6523486Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-04T14:30:55.6523467Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.81956,61.99738]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-10-03T14:30:55.6523492Z\",\"lastEdited\":\"2024-11-05T04:30:55.6523493Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-03T14:30:55.6523489Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.931899999999999,62.11495]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-10-02T14:30:55.6523498Z\",\"lastEdited\":\"2024-11-05T03:30:55.6523498Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-10-02T14:30:55.6523495Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.04424,62.23252]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-10-01T14:30:55.6523503Z\",\"lastEdited\":\"2024-11-05T02:30:55.6523503Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-01T14:30:55.6523500Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.15658,62.35009]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-30T14:30:55.6523508Z\",\"lastEdited\":\"2024-11-05T01:30:55.6523509Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-30T14:30:55.6523506Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.26892,62.46766]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-29T14:30:55.6523514Z\",\"lastEdited\":\"2024-11-05T00:30:55.6523514Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-29T14:30:55.6523511Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.381260000000001,62.58523]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-28T14:30:55.6523519Z\",\"lastEdited\":\"2024-11-04T23:30:55.6523520Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-28T14:30:55.6523516Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.4936,62.702799999999996]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-27T14:30:55.6523524Z\",\"lastEdited\":\"2024-11-04T22:30:55.6523525Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-27T14:30:55.6523521Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60594,62.82037]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-26T14:30:55.6523529Z\",\"lastEdited\":\"2024-11-04T21:30:55.6523530Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-26T14:30:55.6523526Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.71828,62.93794]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-25T14:30:55.6523534Z\",\"lastEdited\":\"2024-11-04T20:30:55.6523535Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-25T14:30:55.6523532Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83062,63.05551]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-24T14:30:55.6523585Z\",\"lastEdited\":\"2024-11-04T19:30:55.6523586Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-24T14:30:55.6523581Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.94296,63.17308]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-23T14:30:55.6523591Z\",\"lastEdited\":\"2024-11-04T18:30:55.6523591Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-23T14:30:55.6523588Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.055299999999999,63.29065]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-22T14:30:55.6523596Z\",\"lastEdited\":\"2024-11-04T17:30:55.6523596Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-22T14:30:55.6523593Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.167639999999999,63.40822]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-21T14:30:55.6523601Z\",\"lastEdited\":\"2024-11-04T16:30:55.6523602Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-21T14:30:55.6523598Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.27998,63.52579]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-20T14:30:55.6523606Z\",\"lastEdited\":\"2024-11-04T15:30:55.6523607Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-20T14:30:55.6523603Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.39232,63.64336]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-19T14:30:55.6523611Z\",\"lastEdited\":\"2024-11-04T14:30:55.6523612Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-19T14:30:55.6523609Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.50466,63.76093]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-18T14:30:55.6523616Z\",\"lastEdited\":\"2024-11-04T13:30:55.6523617Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-18T14:30:55.6523614Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.617,63.8785]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-17T14:30:55.6523622Z\",\"lastEdited\":\"2024-11-04T12:30:55.6523622Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-17T14:30:55.6523619Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.72934,63.99607]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-16T14:30:55.6523627Z\",\"lastEdited\":\"2024-11-04T11:30:55.6523628Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-16T14:30:55.6523624Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.84168,64.11364]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-15T14:30:55.6523633Z\",\"lastEdited\":\"2024-11-04T10:30:55.6523633Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-15T14:30:55.6523630Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.95402,64.23121]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-14T14:30:55.6523707Z\",\"lastEdited\":\"2024-11-04T09:30:55.6523708Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-14T14:30:55.6523704Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.06636,64.34878]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-13T14:30:55.6523712Z\",\"lastEdited\":\"2024-11-04T08:30:55.6523713Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-13T14:30:55.6523710Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.1787,64.46635]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-12T14:30:55.6523717Z\",\"lastEdited\":\"2024-11-04T07:30:55.6523718Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-12T14:30:55.6523715Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291039999999999,64.58392]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-11T14:30:55.6523722Z\",\"lastEdited\":\"2024-11-04T06:30:55.6523723Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-11T14:30:55.6523720Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.403379999999999,64.70149]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-10T14:30:55.6523728Z\",\"lastEdited\":\"2024-11-04T05:30:55.6523728Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-10T14:30:55.6523725Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.51572,64.81906]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-09T14:30:55.6523733Z\",\"lastEdited\":\"2024-11-04T04:30:55.6523734Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-09T14:30:55.6523730Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62806,64.93663]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-08T14:30:55.6523738Z\",\"lastEdited\":\"2024-11-04T03:30:55.6523739Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-08T14:30:55.6523735Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.7404,65.0542]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-07T14:30:55.6523743Z\",\"lastEdited\":\"2024-11-04T02:30:55.6523744Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-07T14:30:55.6523741Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85274,65.17177]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-06T14:30:55.6523749Z\",\"lastEdited\":\"2024-11-04T01:30:55.6523750Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-06T14:30:55.6523746Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.96508,65.28934]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-05T14:30:55.6523754Z\",\"lastEdited\":\"2024-11-04T00:30:55.6523755Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-05T14:30:55.6523751Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07742,65.40691]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-09-04T14:30:55.6523798Z\",\"lastEdited\":\"2024-11-03T23:30:55.6523799Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-04T14:30:55.6523795Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.18976,65.52448]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-09-03T14:30:55.6523804Z\",\"lastEdited\":\"2024-11-03T22:30:55.6523805Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-09-03T14:30:55.6523801Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.3021,65.64205]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-09-02T14:30:55.6523809Z\",\"lastEdited\":\"2024-11-03T21:30:55.6523810Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-09-02T14:30:55.6523807Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.414439999999999,65.75962]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-09-01T14:30:55.6523816Z\",\"lastEdited\":\"2024-11-03T20:30:55.6523816Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-09-01T14:30:55.6523813Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.526779999999999,65.87719]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-31T14:30:55.6523821Z\",\"lastEdited\":\"2024-11-03T19:30:55.6523822Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-31T14:30:55.6523818Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.63912,65.99476]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-30T14:30:55.6523826Z\",\"lastEdited\":\"2024-11-03T18:30:55.6523827Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-30T14:30:55.6523824Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75146,66.11233]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-29T14:30:55.6523832Z\",\"lastEdited\":\"2024-11-03T17:30:55.6523832Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-29T14:30:55.6523829Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.8638,66.2299]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-28T14:30:55.6523837Z\",\"lastEdited\":\"2024-11-03T16:30:55.6523837Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-28T14:30:55.6523834Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.976140000000001,66.34747]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-27T14:30:55.6523881Z\",\"lastEdited\":\"2024-11-03T15:30:55.6523882Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-27T14:30:55.6523839Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.08848,66.46504]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-26T14:30:55.6523887Z\",\"lastEdited\":\"2024-11-03T14:30:55.6523888Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-26T14:30:55.6523884Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20082,66.58261]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-25T14:30:55.6523892Z\",\"lastEdited\":\"2024-11-03T13:30:55.6523893Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-25T14:30:55.6523890Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.31316,66.70018]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-24T14:30:55.6523898Z\",\"lastEdited\":\"2024-11-03T12:30:55.6523898Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-24T14:30:55.6523895Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.4255,66.81775]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-23T14:30:55.6523903Z\",\"lastEdited\":\"2024-11-03T11:30:55.6523904Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-23T14:30:55.6523900Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.53784,66.93532]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-22T14:30:55.6523908Z\",\"lastEdited\":\"2024-11-03T10:30:55.6523909Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-22T14:30:55.6523906Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65018,67.05289]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-21T14:30:55.6523914Z\",\"lastEdited\":\"2024-11-03T09:30:55.6523914Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-21T14:30:55.6523911Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.762520000000002,67.17046]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-20T14:30:55.6523919Z\",\"lastEdited\":\"2024-11-03T08:30:55.6523920Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-20T14:30:55.6523916Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.874859999999998,67.28802999999999]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-19T14:30:55.6523924Z\",\"lastEdited\":\"2024-11-03T07:30:55.6523925Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-19T14:30:55.6523922Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.9872,67.40559999999999]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-18T14:30:55.6523930Z\",\"lastEdited\":\"2024-11-03T06:30:55.6523930Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-18T14:30:55.6523927Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.099539999999998,67.52317]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-17T14:30:55.6523935Z\",\"lastEdited\":\"2024-11-03T05:30:55.6523963Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-17T14:30:55.6523932Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.21188,67.64074]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-16T14:30:55.6523968Z\",\"lastEdited\":\"2024-11-03T04:30:55.6523968Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-16T14:30:55.6523965Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.32422,67.75831]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-15T14:30:55.6523973Z\",\"lastEdited\":\"2024-11-03T03:30:55.6523974Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-15T14:30:55.6523970Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.43656,67.87588]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-14T14:30:55.6523978Z\",\"lastEdited\":\"2024-11-03T02:30:55.6523979Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-14T14:30:55.6523976Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.5489,67.99345]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-13T14:30:55.6523984Z\",\"lastEdited\":\"2024-11-03T01:30:55.6523984Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-13T14:30:55.6523981Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.66124,68.11102]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-12T14:30:55.6523989Z\",\"lastEdited\":\"2024-11-03T00:30:55.6523989Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-12T14:30:55.6523986Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77358,68.22859]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-11T14:30:55.6523994Z\",\"lastEdited\":\"2024-11-02T23:30:55.6523995Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-11T14:30:55.6523991Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.88592,68.34616]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-10T14:30:55.6523999Z\",\"lastEdited\":\"2024-11-02T22:30:55.6524000Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-10T14:30:55.6523996Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998260000000002,68.46373]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-09T14:30:55.6524005Z\",\"lastEdited\":\"2024-11-02T21:30:55.6524005Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-09T14:30:55.6524002Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.110599999999998,68.5813]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-08T14:30:55.6524010Z\",\"lastEdited\":\"2024-11-02T20:30:55.6524010Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-08T14:30:55.6524007Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22294,68.69887]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-07T14:30:55.6524015Z\",\"lastEdited\":\"2024-11-02T19:30:55.6524041Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-07T14:30:55.6524012Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.335279999999997,68.81644]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-06T14:30:55.6524046Z\",\"lastEdited\":\"2024-11-02T18:30:55.6524047Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-06T14:30:55.6524043Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.44762,68.93401]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-05T14:30:55.6524051Z\",\"lastEdited\":\"2024-11-02T17:30:55.6524052Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-05T14:30:55.6524049Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.55996,69.05158]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-08-04T14:30:55.6524057Z\",\"lastEdited\":\"2024-11-02T16:30:55.6524057Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-08-04T14:30:55.6524054Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.6723,69.16915]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-08-03T14:30:55.6524062Z\",\"lastEdited\":\"2024-11-02T15:30:55.6524063Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-03T14:30:55.6524059Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.78464,69.28672]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-08-02T14:30:55.6524067Z\",\"lastEdited\":\"2024-11-02T14:30:55.6524068Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-08-02T14:30:55.6524065Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89698,69.40429]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-08-01T14:30:55.6524073Z\",\"lastEdited\":\"2024-11-02T13:30:55.6524073Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "Uåpnet", "2024-08-01T14:30:55.6524070Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.00932,69.52186]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-31T14:30:55.6524078Z\",\"lastEdited\":\"2024-11-02T12:30:55.6524078Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-07-31T14:30:55.6524075Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12166,69.63943]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-30T14:30:55.6524083Z\",\"lastEdited\":\"2024-11-02T11:30:55.6524084Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-07-30T14:30:55.6524080Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234,69.757]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-29T14:30:55.6524089Z\",\"lastEdited\":\"2024-11-02T10:30:55.6524090Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-07-29T14:30:55.6524086Z" });
        }
    }
}
