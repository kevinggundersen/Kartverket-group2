using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubmissionData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Comment", "GeoJsonData", "Municipalitynr", "Status", "Timestamp" },
                values: new object[,]
                {
                    { 11L, "Test submission 11", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.23579635795,59.293285697]},\"properties\":{\"id\":11,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 11\",\"addedAt\":\"2024-10-22T19:05:27.3583790Z\",\"lastEdited\":\"2024-11-02T08:05:27.3583790Z\",\"radius\":115.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3011", "Uåpnet", "2024-10-22T19:05:27.3583787Z" },
                    { 12L, "Test submission 12", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.348141481399999,59.410857124]},\"properties\":{\"id\":12,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 12\",\"addedAt\":\"2024-10-21T19:05:27.3583795Z\",\"lastEdited\":\"2024-11-02T07:05:27.3583796Z\",\"radius\":126}}],\"activeTileLayer\":\"Standard\"}", "3012", "Akseptert", "2024-10-21T19:05:27.3583792Z" },
                    { 13L, "Test submission 13", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.46048660485,59.528428551]},\"properties\":{\"id\":13,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 13\",\"addedAt\":\"2024-10-20T19:05:27.3583800Z\",\"lastEdited\":\"2024-11-02T06:05:27.3583801Z\",\"radius\":136.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3013", "Uåpnet", "2024-10-20T19:05:27.3583797Z" },
                    { 14L, "Test submission 14", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.5728317283,59.645999978]},\"properties\":{\"id\":14,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 14\",\"addedAt\":\"2024-10-19T19:05:27.3583805Z\",\"lastEdited\":\"2024-11-02T05:05:27.3583806Z\",\"radius\":147}}],\"activeTileLayer\":\"Turkart\"}", "3014", "Under arbeid", "2024-10-19T19:05:27.3583802Z" },
                    { 15L, "Test submission 15", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.68517685175,59.763571405]},\"properties\":{\"id\":15,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 15\",\"addedAt\":\"2024-10-18T19:05:27.3583810Z\",\"lastEdited\":\"2024-11-02T04:05:27.3583811Z\",\"radius\":157.5}}],\"activeTileLayer\":\"Standard\"}", "3015", "Akseptert", "2024-10-18T19:05:27.3583808Z" },
                    { 16L, "Test submission 16", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.7975219752,59.881142832]},\"properties\":{\"id\":16,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 16\",\"addedAt\":\"2024-10-17T19:05:27.3583831Z\",\"lastEdited\":\"2024-11-02T03:05:27.3583831Z\",\"radius\":168}}],\"activeTileLayer\":\"Turkart\"}", "3016", "Under arbeid", "2024-10-17T19:05:27.3583828Z" },
                    { 17L, "Test submission 17", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.90986709865,59.998714259]},\"properties\":{\"id\":17,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 17\",\"addedAt\":\"2024-10-16T19:05:27.3583836Z\",\"lastEdited\":\"2024-11-02T02:05:27.3583837Z\",\"radius\":178.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3017", "Uåpnet", "2024-10-16T19:05:27.3583833Z" },
                    { 18L, "Test submission 18", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.0222122221,60.116285686]},\"properties\":{\"id\":18,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 18\",\"addedAt\":\"2024-10-15T19:05:27.3583842Z\",\"lastEdited\":\"2024-11-02T01:05:27.3583843Z\",\"radius\":189}}],\"activeTileLayer\":\"Standard\"}", "3018", "Akseptert", "2024-10-15T19:05:27.3583839Z" },
                    { 19L, "Test submission 19", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.13455734555,60.233857113]},\"properties\":{\"id\":19,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 19\",\"addedAt\":\"2024-10-14T19:05:27.3583847Z\",\"lastEdited\":\"2024-11-02T00:05:27.3583848Z\",\"radius\":199.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3019", "Uåpnet", "2024-10-14T19:05:27.3583844Z" },
                    { 20L, "Test submission 20", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.246902469,60.35142854]},\"properties\":{\"id\":20,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 20\",\"addedAt\":\"2024-10-13T19:05:27.3583852Z\",\"lastEdited\":\"2024-11-01T23:05:27.3583853Z\",\"radius\":210}}],\"activeTileLayer\":\"Turkart\"}", "3020", "Under arbeid", "2024-10-13T19:05:27.3583849Z" },
                    { 21L, "Test submission 21", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.35924759245,60.468999967]},\"properties\":{\"id\":21,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 21\",\"addedAt\":\"2024-10-12T19:05:27.3583857Z\",\"lastEdited\":\"2024-11-01T22:05:27.3583858Z\",\"radius\":220.5}}],\"activeTileLayer\":\"Standard\"}", "3021", "Akseptert", "2024-10-12T19:05:27.3583855Z" },
                    { 22L, "Test submission 22", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.4715927159,60.586571394]},\"properties\":{\"id\":22,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 22\",\"addedAt\":\"2024-10-11T19:05:27.3583862Z\",\"lastEdited\":\"2024-11-01T21:05:27.3583863Z\",\"radius\":231}}],\"activeTileLayer\":\"Turkart\"}", "3022", "Under arbeid", "2024-10-11T19:05:27.3583860Z" },
                    { 23L, "Test submission 23", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.58393783935,60.704142821]},\"properties\":{\"id\":23,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 23\",\"addedAt\":\"2024-10-10T19:05:27.3583867Z\",\"lastEdited\":\"2024-11-01T20:05:27.3583868Z\",\"radius\":241.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3023", "Uåpnet", "2024-10-10T19:05:27.3583865Z" },
                    { 24L, "Test submission 24", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.6962829628,60.821714248]},\"properties\":{\"id\":24,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 24\",\"addedAt\":\"2024-10-09T19:05:27.3583873Z\",\"lastEdited\":\"2024-11-01T19:05:27.3583873Z\",\"radius\":252}}],\"activeTileLayer\":\"Standard\"}", "3024", "Akseptert", "2024-10-09T19:05:27.3583870Z" },
                    { 25L, "Test submission 25", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.80862808625,60.939285675]},\"properties\":{\"id\":25,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 25\",\"addedAt\":\"2024-10-08T19:05:27.3583926Z\",\"lastEdited\":\"2024-11-01T18:05:27.3583926Z\",\"radius\":262.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3025", "Uåpnet", "2024-10-08T19:05:27.3583875Z" },
                    { 26L, "Test submission 26", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.9209732097,61.056857102]},\"properties\":{\"id\":26,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 26\",\"addedAt\":\"2024-10-07T19:05:27.3583931Z\",\"lastEdited\":\"2024-11-01T17:05:27.3583932Z\",\"radius\":273}}],\"activeTileLayer\":\"Turkart\"}", "3026", "Under arbeid", "2024-10-07T19:05:27.3583928Z" },
                    { 27L, "Test submission 27", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.03331833315,61.174428529]},\"properties\":{\"id\":27,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 27\",\"addedAt\":\"2024-10-06T19:05:27.3583936Z\",\"lastEdited\":\"2024-11-01T16:05:27.3583937Z\",\"radius\":283.5}}],\"activeTileLayer\":\"Standard\"}", "3027", "Akseptert", "2024-10-06T19:05:27.3583934Z" },
                    { 28L, "Test submission 28", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.1456634566,61.291999956]},\"properties\":{\"id\":28,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 28\",\"addedAt\":\"2024-10-05T19:05:27.3583941Z\",\"lastEdited\":\"2024-11-01T15:05:27.3583942Z\",\"radius\":294}}],\"activeTileLayer\":\"Turkart\"}", "3028", "Under arbeid", "2024-10-05T19:05:27.3583939Z" },
                    { 29L, "Test submission 29", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.25800858005,61.409571383]},\"properties\":{\"id\":29,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 29\",\"addedAt\":\"2024-10-04T19:05:27.3583946Z\",\"lastEdited\":\"2024-11-01T14:05:27.3583947Z\",\"radius\":304.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3029", "Uåpnet", "2024-10-04T19:05:27.3583944Z" },
                    { 30L, "Test submission 30", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.370353703500001,61.52714281]},\"properties\":{\"id\":30,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 30\",\"addedAt\":\"2024-10-03T19:05:27.3583951Z\",\"lastEdited\":\"2024-11-01T13:05:27.3583952Z\",\"radius\":315}}],\"activeTileLayer\":\"Standard\"}", "3030", "Akseptert", "2024-10-03T19:05:27.3583949Z" },
                    { 31L, "Test submission 31", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.48269882695,61.644714237]},\"properties\":{\"id\":31,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 31\",\"addedAt\":\"2024-10-02T19:05:27.3583957Z\",\"lastEdited\":\"2024-11-01T12:05:27.3583957Z\",\"radius\":325.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3031", "Uåpnet", "2024-10-02T19:05:27.3583954Z" },
                    { 32L, "Test submission 32", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.595043950400001,61.762285664000004]},\"properties\":{\"id\":32,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 32\",\"addedAt\":\"2024-10-01T19:05:27.3583961Z\",\"lastEdited\":\"2024-11-01T11:05:27.3583962Z\",\"radius\":336}}],\"activeTileLayer\":\"Turkart\"}", "3032", "Under arbeid", "2024-10-01T19:05:27.3583959Z" },
                    { 33L, "Test submission 33", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.707389073849999,61.879857091]},\"properties\":{\"id\":33,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 33\",\"addedAt\":\"2024-09-30T19:05:27.3583967Z\",\"lastEdited\":\"2024-11-01T10:05:27.3583967Z\",\"radius\":346.5}}],\"activeTileLayer\":\"Standard\"}", "3033", "Akseptert", "2024-09-30T19:05:27.3583964Z" },
                    { 34L, "Test submission 34", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.8197341973,61.997428518]},\"properties\":{\"id\":34,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 34\",\"addedAt\":\"2024-09-29T19:05:27.3583973Z\",\"lastEdited\":\"2024-11-01T09:05:27.3583974Z\",\"radius\":357}}],\"activeTileLayer\":\"Turkart\"}", "3034", "Under arbeid", "2024-09-29T19:05:27.3583970Z" },
                    { 35L, "Test submission 35", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11.93207932075,62.114999945]},\"properties\":{\"id\":35,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 35\",\"addedAt\":\"2024-09-28T19:05:27.3584017Z\",\"lastEdited\":\"2024-11-01T08:05:27.3584018Z\",\"radius\":367.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3035", "Uåpnet", "2024-09-28T19:05:27.3584014Z" },
                    { 36L, "Test submission 36", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.0444244442,62.232571372]},\"properties\":{\"id\":36,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 36\",\"addedAt\":\"2024-09-27T19:05:27.3584022Z\",\"lastEdited\":\"2024-11-01T07:05:27.3584023Z\",\"radius\":378}}],\"activeTileLayer\":\"Standard\"}", "3036", "Akseptert", "2024-09-27T19:05:27.3584019Z" },
                    { 37L, "Test submission 37", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.156769567649999,62.350142799]},\"properties\":{\"id\":37,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 37\",\"addedAt\":\"2024-09-26T19:05:27.3584027Z\",\"lastEdited\":\"2024-11-01T06:05:27.3584028Z\",\"radius\":388.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3037", "Uåpnet", "2024-09-26T19:05:27.3584024Z" },
                    { 38L, "Test submission 38", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.2691146911,62.467714226]},\"properties\":{\"id\":38,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 38\",\"addedAt\":\"2024-09-25T19:05:27.3584032Z\",\"lastEdited\":\"2024-11-01T05:05:27.3584033Z\",\"radius\":399}}],\"activeTileLayer\":\"Turkart\"}", "3038", "Under arbeid", "2024-09-25T19:05:27.3584030Z" },
                    { 39L, "Test submission 39", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.38145981455,62.585285653]},\"properties\":{\"id\":39,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 39\",\"addedAt\":\"2024-09-24T19:05:27.3584037Z\",\"lastEdited\":\"2024-11-01T04:05:27.3584038Z\",\"radius\":409.5}}],\"activeTileLayer\":\"Standard\"}", "3039", "Akseptert", "2024-09-24T19:05:27.3584034Z" },
                    { 40L, "Test submission 40", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.493804938,62.70285708]},\"properties\":{\"id\":40,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 40\",\"addedAt\":\"2024-09-23T19:05:27.3584042Z\",\"lastEdited\":\"2024-11-01T03:05:27.3584043Z\",\"radius\":420}}],\"activeTileLayer\":\"Turkart\"}", "3040", "Under arbeid", "2024-09-23T19:05:27.3584040Z" },
                    { 41L, "Test submission 41", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.60615006145,62.820428507]},\"properties\":{\"id\":41,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 41\",\"addedAt\":\"2024-09-22T19:05:27.3584047Z\",\"lastEdited\":\"2024-11-01T02:05:27.3584048Z\",\"radius\":430.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3041", "Uåpnet", "2024-09-22T19:05:27.3584044Z" },
                    { 42L, "Test submission 42", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.7184951849,62.937999934000004]},\"properties\":{\"id\":42,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 42\",\"addedAt\":\"2024-09-21T19:05:27.3584052Z\",\"lastEdited\":\"2024-11-01T01:05:27.3584053Z\",\"radius\":441}}],\"activeTileLayer\":\"Standard\"}", "3042", "Akseptert", "2024-09-21T19:05:27.3584049Z" },
                    { 43L, "Test submission 43", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.83084030835,63.055571361]},\"properties\":{\"id\":43,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 43\",\"addedAt\":\"2024-09-20T19:05:27.3584057Z\",\"lastEdited\":\"2024-11-01T00:05:27.3584058Z\",\"radius\":451.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3043", "Uåpnet", "2024-09-20T19:05:27.3584054Z" },
                    { 44L, "Test submission 44", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[12.9431854318,63.173142788]},\"properties\":{\"id\":44,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 44\",\"addedAt\":\"2024-09-19T19:05:27.3584062Z\",\"lastEdited\":\"2024-10-31T23:05:27.3584063Z\",\"radius\":462}}],\"activeTileLayer\":\"Turkart\"}", "3044", "Under arbeid", "2024-09-19T19:05:27.3584060Z" },
                    { 45L, "Test submission 45", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.05553055525,63.290714215]},\"properties\":{\"id\":45,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 45\",\"addedAt\":\"2024-09-18T19:05:27.3584094Z\",\"lastEdited\":\"2024-10-31T22:05:27.3584095Z\",\"radius\":472.5}}],\"activeTileLayer\":\"Standard\"}", "3045", "Akseptert", "2024-09-18T19:05:27.3584091Z" },
                    { 46L, "Test submission 46", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.1678756787,63.408285642]},\"properties\":{\"id\":46,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 46\",\"addedAt\":\"2024-09-17T19:05:27.3584099Z\",\"lastEdited\":\"2024-10-31T21:05:27.3584100Z\",\"radius\":483}}],\"activeTileLayer\":\"Turkart\"}", "3046", "Under arbeid", "2024-09-17T19:05:27.3584097Z" },
                    { 47L, "Test submission 47", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.28022080215,63.525857069]},\"properties\":{\"id\":47,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 47\",\"addedAt\":\"2024-09-16T19:05:27.3584104Z\",\"lastEdited\":\"2024-10-31T20:05:27.3584105Z\",\"radius\":493.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3047", "Uåpnet", "2024-09-16T19:05:27.3584102Z" },
                    { 48L, "Test submission 48", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.3925659256,63.643428496]},\"properties\":{\"id\":48,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 48\",\"addedAt\":\"2024-09-15T19:05:27.3584109Z\",\"lastEdited\":\"2024-10-31T19:05:27.3584110Z\",\"radius\":504}}],\"activeTileLayer\":\"Standard\"}", "3048", "Akseptert", "2024-09-15T19:05:27.3584107Z" },
                    { 49L, "Test submission 49", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.504911049050001,63.760999923]},\"properties\":{\"id\":49,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 49\",\"addedAt\":\"2024-09-14T19:05:27.3584114Z\",\"lastEdited\":\"2024-10-31T18:05:27.3584115Z\",\"radius\":514.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3049", "Uåpnet", "2024-09-14T19:05:27.3584112Z" },
                    { 50L, "Test submission 50", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.6172561725,63.87857135]},\"properties\":{\"id\":50,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 50\",\"addedAt\":\"2024-09-13T19:05:27.3584119Z\",\"lastEdited\":\"2024-10-31T17:05:27.3584120Z\",\"radius\":525}}],\"activeTileLayer\":\"Turkart\"}", "3050", "Under arbeid", "2024-09-13T19:05:27.3584117Z" },
                    { 51L, "Test submission 51", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.729601295950001,63.996142777]},\"properties\":{\"id\":51,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 51\",\"addedAt\":\"2024-09-12T19:05:27.3584124Z\",\"lastEdited\":\"2024-10-31T16:05:27.3584125Z\",\"radius\":535.5}}],\"activeTileLayer\":\"Standard\"}", "3051", "Akseptert", "2024-09-12T19:05:27.3584121Z" },
                    { 52L, "Test submission 52", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.8419464194,64.113714204]},\"properties\":{\"id\":52,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 52\",\"addedAt\":\"2024-09-11T19:05:27.3584129Z\",\"lastEdited\":\"2024-10-31T15:05:27.3584130Z\",\"radius\":546}}],\"activeTileLayer\":\"Turkart\"}", "3052", "Under arbeid", "2024-09-11T19:05:27.3584126Z" },
                    { 53L, "Test submission 53", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[13.954291542850001,64.231285631]},\"properties\":{\"id\":53,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 53\",\"addedAt\":\"2024-09-10T19:05:27.3584134Z\",\"lastEdited\":\"2024-10-31T14:05:27.3584135Z\",\"radius\":556.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3053", "Uåpnet", "2024-09-10T19:05:27.3584131Z" },
                    { 54L, "Test submission 54", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.066636666299999,64.348857058]},\"properties\":{\"id\":54,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 54\",\"addedAt\":\"2024-09-09T19:05:27.3584139Z\",\"lastEdited\":\"2024-10-31T13:05:27.3584140Z\",\"radius\":567}}],\"activeTileLayer\":\"Standard\"}", "3054", "Akseptert", "2024-09-09T19:05:27.3584136Z" },
                    { 55L, "Test submission 55", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.17898178975,64.466428485]},\"properties\":{\"id\":55,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 55\",\"addedAt\":\"2024-09-08T19:05:27.3584170Z\",\"lastEdited\":\"2024-10-31T12:05:27.3584171Z\",\"radius\":577.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3055", "Uåpnet", "2024-09-08T19:05:27.3584141Z" },
                    { 56L, "Test submission 56", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.291326913199999,64.583999912]},\"properties\":{\"id\":56,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 56\",\"addedAt\":\"2024-09-07T19:05:27.3584175Z\",\"lastEdited\":\"2024-10-31T11:05:27.3584176Z\",\"radius\":588}}],\"activeTileLayer\":\"Turkart\"}", "3056", "Under arbeid", "2024-09-07T19:05:27.3584173Z" },
                    { 57L, "Test submission 57", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.40367203665,64.701571339]},\"properties\":{\"id\":57,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 57\",\"addedAt\":\"2024-09-06T19:05:27.3584181Z\",\"lastEdited\":\"2024-10-31T10:05:27.3584181Z\",\"radius\":598.5}}],\"activeTileLayer\":\"Standard\"}", "3057", "Akseptert", "2024-09-06T19:05:27.3584178Z" },
                    { 58L, "Test submission 58", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.516017160099999,64.819142766]},\"properties\":{\"id\":58,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 58\",\"addedAt\":\"2024-09-05T19:05:27.3584186Z\",\"lastEdited\":\"2024-10-31T09:05:27.3584186Z\",\"radius\":609}}],\"activeTileLayer\":\"Turkart\"}", "3058", "Under arbeid", "2024-09-05T19:05:27.3584183Z" },
                    { 59L, "Test submission 59", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.62836228355,64.936714193]},\"properties\":{\"id\":59,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 59\",\"addedAt\":\"2024-09-04T19:05:27.3584191Z\",\"lastEdited\":\"2024-10-31T08:05:27.3584191Z\",\"radius\":619.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3059", "Uåpnet", "2024-09-04T19:05:27.3584188Z" },
                    { 60L, "Test submission 60", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.740707407,65.05428562]},\"properties\":{\"id\":60,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 60\",\"addedAt\":\"2024-09-03T19:05:27.3584196Z\",\"lastEdited\":\"2024-10-31T07:05:27.3584197Z\",\"radius\":630}}],\"activeTileLayer\":\"Standard\"}", "3060", "Akseptert", "2024-09-03T19:05:27.3584193Z" },
                    { 61L, "Test submission 61", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.85305253045,65.171857047]},\"properties\":{\"id\":61,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 61\",\"addedAt\":\"2024-09-02T19:05:27.3584201Z\",\"lastEdited\":\"2024-10-31T06:05:27.3584202Z\",\"radius\":640.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3061", "Uåpnet", "2024-09-02T19:05:27.3584198Z" },
                    { 62L, "Test submission 62", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[14.9653976539,65.289428474]},\"properties\":{\"id\":62,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 62\",\"addedAt\":\"2024-09-01T19:05:27.3584206Z\",\"lastEdited\":\"2024-10-31T05:05:27.3584206Z\",\"radius\":651}}],\"activeTileLayer\":\"Turkart\"}", "3062", "Under arbeid", "2024-09-01T19:05:27.3584203Z" },
                    { 63L, "Test submission 63", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.07774277735,65.406999901]},\"properties\":{\"id\":63,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 63\",\"addedAt\":\"2024-08-31T19:05:27.3584211Z\",\"lastEdited\":\"2024-10-31T04:05:27.3584211Z\",\"radius\":661.5}}],\"activeTileLayer\":\"Standard\"}", "3063", "Akseptert", "2024-08-31T19:05:27.3584208Z" },
                    { 64L, "Test submission 64", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.1900879008,65.52457132800001]},\"properties\":{\"id\":64,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 64\",\"addedAt\":\"2024-08-30T19:05:27.3584216Z\",\"lastEdited\":\"2024-10-31T03:05:27.3584216Z\",\"radius\":672}}],\"activeTileLayer\":\"Turkart\"}", "3064", "Under arbeid", "2024-08-30T19:05:27.3584213Z" },
                    { 65L, "Test submission 65", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.30243302425,65.642142755]},\"properties\":{\"id\":65,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 65\",\"addedAt\":\"2024-08-29T19:05:27.3584246Z\",\"lastEdited\":\"2024-10-31T02:05:27.3584247Z\",\"radius\":682.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3065", "Uåpnet", "2024-08-29T19:05:27.3584218Z" },
                    { 66L, "Test submission 66", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.4147781477,65.759714182]},\"properties\":{\"id\":66,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 66\",\"addedAt\":\"2024-08-28T19:05:27.3584253Z\",\"lastEdited\":\"2024-10-31T01:05:27.3584254Z\",\"radius\":693}}],\"activeTileLayer\":\"Standard\"}", "3066", "Akseptert", "2024-08-28T19:05:27.3584250Z" },
                    { 67L, "Test submission 67", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.52712327115,65.877285609]},\"properties\":{\"id\":67,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 67\",\"addedAt\":\"2024-08-27T19:05:27.3584258Z\",\"lastEdited\":\"2024-10-31T00:05:27.3584259Z\",\"radius\":703.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3067", "Uåpnet", "2024-08-27T19:05:27.3584255Z" },
                    { 68L, "Test submission 68", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.6394683946,65.994857036]},\"properties\":{\"id\":68,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 68\",\"addedAt\":\"2024-08-26T19:05:27.3584263Z\",\"lastEdited\":\"2024-10-30T23:05:27.3584264Z\",\"radius\":714}}],\"activeTileLayer\":\"Turkart\"}", "3068", "Under arbeid", "2024-08-26T19:05:27.3584260Z" },
                    { 69L, "Test submission 69", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.75181351805,66.112428463]},\"properties\":{\"id\":69,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 69\",\"addedAt\":\"2024-08-25T19:05:27.3584268Z\",\"lastEdited\":\"2024-10-30T22:05:27.3584269Z\",\"radius\":724.5}}],\"activeTileLayer\":\"Standard\"}", "3069", "Akseptert", "2024-08-25T19:05:27.3584265Z" },
                    { 70L, "Test submission 70", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.864158641500001,66.22999989]},\"properties\":{\"id\":70,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 70\",\"addedAt\":\"2024-08-24T19:05:27.3584273Z\",\"lastEdited\":\"2024-10-30T21:05:27.3584273Z\",\"radius\":735}}],\"activeTileLayer\":\"Turkart\"}", "3070", "Under arbeid", "2024-08-24T19:05:27.3584270Z" },
                    { 71L, "Test submission 71", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[15.97650376495,66.347571317]},\"properties\":{\"id\":71,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 71\",\"addedAt\":\"2024-08-23T19:05:27.3584278Z\",\"lastEdited\":\"2024-10-30T20:05:27.3584278Z\",\"radius\":745.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3071", "Uåpnet", "2024-08-23T19:05:27.3584275Z" },
                    { 72L, "Test submission 72", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.0888488884,66.465142744]},\"properties\":{\"id\":72,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 72\",\"addedAt\":\"2024-08-22T19:05:27.3584283Z\",\"lastEdited\":\"2024-10-30T19:05:27.3584283Z\",\"radius\":756}}],\"activeTileLayer\":\"Standard\"}", "3072", "Akseptert", "2024-08-22T19:05:27.3584280Z" },
                    { 73L, "Test submission 73", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.20119401185,66.582714171]},\"properties\":{\"id\":73,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 73\",\"addedAt\":\"2024-08-21T19:05:27.3584288Z\",\"lastEdited\":\"2024-10-30T18:05:27.3584289Z\",\"radius\":766.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3073", "Uåpnet", "2024-08-21T19:05:27.3584285Z" },
                    { 74L, "Test submission 74", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.313539135299997,66.700285598]},\"properties\":{\"id\":74,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 74\",\"addedAt\":\"2024-08-20T19:05:27.3584319Z\",\"lastEdited\":\"2024-10-30T17:05:27.3584320Z\",\"radius\":777}}],\"activeTileLayer\":\"Turkart\"}", "3074", "Under arbeid", "2024-08-20T19:05:27.3584290Z" },
                    { 75L, "Test submission 75", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.425884258750003,66.817857025]},\"properties\":{\"id\":75,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 75\",\"addedAt\":\"2024-08-19T19:05:27.3584325Z\",\"lastEdited\":\"2024-10-30T16:05:27.3584325Z\",\"radius\":787.5}}],\"activeTileLayer\":\"Standard\"}", "3075", "Akseptert", "2024-08-19T19:05:27.3584322Z" },
                    { 76L, "Test submission 76", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.5382293822,66.935428452]},\"properties\":{\"id\":76,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 76\",\"addedAt\":\"2024-08-18T19:05:27.3584329Z\",\"lastEdited\":\"2024-10-30T15:05:27.3584330Z\",\"radius\":798}}],\"activeTileLayer\":\"Turkart\"}", "3076", "Under arbeid", "2024-08-18T19:05:27.3584327Z" },
                    { 77L, "Test submission 77", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.65057450565,67.052999879]},\"properties\":{\"id\":77,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 77\",\"addedAt\":\"2024-08-17T19:05:27.3584335Z\",\"lastEdited\":\"2024-10-30T14:05:27.3584335Z\",\"radius\":808.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3077", "Uåpnet", "2024-08-17T19:05:27.3584332Z" },
                    { 78L, "Test submission 78", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.7629196291,67.170571306]},\"properties\":{\"id\":78,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 78\",\"addedAt\":\"2024-08-16T19:05:27.3584340Z\",\"lastEdited\":\"2024-10-30T13:05:27.3584340Z\",\"radius\":819}}],\"activeTileLayer\":\"Standard\"}", "3078", "Akseptert", "2024-08-16T19:05:27.3584337Z" },
                    { 79L, "Test submission 79", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.875264752550002,67.288142733]},\"properties\":{\"id\":79,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 79\",\"addedAt\":\"2024-08-15T19:05:27.3584345Z\",\"lastEdited\":\"2024-10-30T12:05:27.3584345Z\",\"radius\":829.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3079", "Uåpnet", "2024-08-15T19:05:27.3584342Z" },
                    { 80L, "Test submission 80", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[16.987609876,67.40571416]},\"properties\":{\"id\":80,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 80\",\"addedAt\":\"2024-08-14T19:05:27.3584349Z\",\"lastEdited\":\"2024-10-30T11:05:27.3584350Z\",\"radius\":840}}],\"activeTileLayer\":\"Turkart\"}", "3080", "Under arbeid", "2024-08-14T19:05:27.3584347Z" },
                    { 81L, "Test submission 81", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.09995499945,67.523285587]},\"properties\":{\"id\":81,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 81\",\"addedAt\":\"2024-08-13T19:05:27.3584354Z\",\"lastEdited\":\"2024-10-30T10:05:27.3584355Z\",\"radius\":850.5}}],\"activeTileLayer\":\"Standard\"}", "3081", "Akseptert", "2024-08-13T19:05:27.3584352Z" },
                    { 82L, "Test submission 82", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.2123001229,67.640857014]},\"properties\":{\"id\":82,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 82\",\"addedAt\":\"2024-08-12T19:05:27.3584359Z\",\"lastEdited\":\"2024-10-30T09:05:27.3584360Z\",\"radius\":861}}],\"activeTileLayer\":\"Turkart\"}", "3082", "Under arbeid", "2024-08-12T19:05:27.3584357Z" },
                    { 83L, "Test submission 83", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.324645246350002,67.758428441]},\"properties\":{\"id\":83,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 83\",\"addedAt\":\"2024-08-11T19:05:27.3584364Z\",\"lastEdited\":\"2024-10-30T08:05:27.3584365Z\",\"radius\":871.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3083", "Uåpnet", "2024-08-11T19:05:27.3584362Z" },
                    { 84L, "Test submission 84", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.4369903698,67.87599986800001]},\"properties\":{\"id\":84,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 84\",\"addedAt\":\"2024-08-10T19:05:27.3584394Z\",\"lastEdited\":\"2024-10-30T07:05:27.3584395Z\",\"radius\":882}}],\"activeTileLayer\":\"Standard\"}", "3084", "Akseptert", "2024-08-10T19:05:27.3584367Z" },
                    { 85L, "Test submission 85", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.54933549325,67.993571295]},\"properties\":{\"id\":85,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 85\",\"addedAt\":\"2024-08-09T19:05:27.3584399Z\",\"lastEdited\":\"2024-10-30T06:05:27.3584400Z\",\"radius\":892.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3085", "Uåpnet", "2024-08-09T19:05:27.3584397Z" },
                    { 86L, "Test submission 86", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.6616806167,68.111142722]},\"properties\":{\"id\":86,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 86\",\"addedAt\":\"2024-08-08T19:05:27.3584404Z\",\"lastEdited\":\"2024-10-30T05:05:27.3584405Z\",\"radius\":903}}],\"activeTileLayer\":\"Turkart\"}", "3086", "Under arbeid", "2024-08-08T19:05:27.3584401Z" },
                    { 87L, "Test submission 87", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.77402574015,68.228714149]},\"properties\":{\"id\":87,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 87\",\"addedAt\":\"2024-08-07T19:05:27.3584409Z\",\"lastEdited\":\"2024-10-30T04:05:27.3584410Z\",\"radius\":913.5}}],\"activeTileLayer\":\"Standard\"}", "3087", "Akseptert", "2024-08-07T19:05:27.3584406Z" },
                    { 88L, "Test submission 88", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.8863708636,68.346285576]},\"properties\":{\"id\":88,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 88\",\"addedAt\":\"2024-08-06T19:05:27.3584414Z\",\"lastEdited\":\"2024-10-30T03:05:27.3584415Z\",\"radius\":924}}],\"activeTileLayer\":\"Turkart\"}", "3088", "Under arbeid", "2024-08-06T19:05:27.3584411Z" },
                    { 89L, "Test submission 89", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[17.998715987049998,68.463857003]},\"properties\":{\"id\":89,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 89\",\"addedAt\":\"2024-08-05T19:05:27.3584419Z\",\"lastEdited\":\"2024-10-30T02:05:27.3584420Z\",\"radius\":934.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3089", "Uåpnet", "2024-08-05T19:05:27.3584417Z" },
                    { 90L, "Test submission 90", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.1110611105,68.58142843]},\"properties\":{\"id\":90,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 90\",\"addedAt\":\"2024-08-04T19:05:27.3584425Z\",\"lastEdited\":\"2024-10-30T01:05:27.3584425Z\",\"radius\":945}}],\"activeTileLayer\":\"Standard\"}", "3090", "Akseptert", "2024-08-04T19:05:27.3584422Z" },
                    { 91L, "Test submission 91", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.22340623395,68.698999857]},\"properties\":{\"id\":91,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 91\",\"addedAt\":\"2024-08-03T19:05:27.3584430Z\",\"lastEdited\":\"2024-10-30T00:05:27.3584430Z\",\"radius\":955.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3091", "Uåpnet", "2024-08-03T19:05:27.3584427Z" },
                    { 92L, "Test submission 92", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.3357513574,68.816571284]},\"properties\":{\"id\":92,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 92\",\"addedAt\":\"2024-08-02T19:05:27.3584435Z\",\"lastEdited\":\"2024-10-29T23:05:27.3584435Z\",\"radius\":966}}],\"activeTileLayer\":\"Turkart\"}", "3092", "Under arbeid", "2024-08-02T19:05:27.3584432Z" },
                    { 93L, "Test submission 93", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.448096480849998,68.93414271099999]},\"properties\":{\"id\":93,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 93\",\"addedAt\":\"2024-08-01T19:05:27.3584440Z\",\"lastEdited\":\"2024-10-29T22:05:27.3584441Z\",\"radius\":976.5}}],\"activeTileLayer\":\"Standard\"}", "3093", "Akseptert", "2024-08-01T19:05:27.3584437Z" },
                    { 94L, "Test submission 94", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.5604416043,69.051714138]},\"properties\":{\"id\":94,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 94\",\"addedAt\":\"2024-07-31T19:05:27.3584463Z\",\"lastEdited\":\"2024-10-29T21:05:27.3584464Z\",\"radius\":987}}],\"activeTileLayer\":\"Turkart\"}", "3094", "Under arbeid", "2024-07-31T19:05:27.3584442Z" },
                    { 95L, "Test submission 95", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.67278672775,69.169285565]},\"properties\":{\"id\":95,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 95\",\"addedAt\":\"2024-07-30T19:05:27.3584469Z\",\"lastEdited\":\"2024-10-29T20:05:27.3584470Z\",\"radius\":997.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3095", "Uåpnet", "2024-07-30T19:05:27.3584466Z" },
                    { 96L, "Test submission 96", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.7851318512,69.286856992]},\"properties\":{\"id\":96,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 96\",\"addedAt\":\"2024-07-29T19:05:27.3584474Z\",\"lastEdited\":\"2024-10-29T19:05:27.3584475Z\",\"radius\":1008}}],\"activeTileLayer\":\"Standard\"}", "3096", "Akseptert", "2024-07-29T19:05:27.3584472Z" },
                    { 97L, "Test submission 97", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[18.89747697465,69.404428419]},\"properties\":{\"id\":97,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 97\",\"addedAt\":\"2024-07-28T19:05:27.3584479Z\",\"lastEdited\":\"2024-10-29T18:05:27.3584480Z\",\"radius\":1018.5}}],\"activeTileLayer\":\"Sattelitt\"}", "3097", "Uåpnet", "2024-07-28T19:05:27.3584477Z" },
                    { 98L, "Test submission 98", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.009822098100003,69.521999846]},\"properties\":{\"id\":98,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 98\",\"addedAt\":\"2024-07-27T19:05:27.3584484Z\",\"lastEdited\":\"2024-10-29T17:05:27.3584485Z\",\"radius\":1029}}],\"activeTileLayer\":\"Turkart\"}", "3098", "Under arbeid", "2024-07-27T19:05:27.3584482Z" },
                    { 99L, "Test submission 99", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.12216722155,69.639571273]},\"properties\":{\"id\":99,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 99\",\"addedAt\":\"2024-07-26T19:05:27.3584489Z\",\"lastEdited\":\"2024-10-29T16:05:27.3584490Z\",\"radius\":1039.5}}],\"activeTileLayer\":\"Standard\"}", "3099", "Akseptert", "2024-07-26T19:05:27.3584487Z" },
                    { 100L, "Test submission 100", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[19.234512345,69.7571427]},\"properties\":{\"id\":100,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 100\",\"addedAt\":\"2024-07-25T19:05:27.3584495Z\",\"lastEdited\":\"2024-10-29T15:05:27.3584495Z\",\"radius\":1050}}],\"activeTileLayer\":\"Turkart\"}", "3100", "Under arbeid", "2024-07-25T19:05:27.3584492Z" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.11234512345,58.117571427]},\"properties\":{\"id\":1,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-01T18:53:42.1921829Z\",\"lastEdited\":\"2024-11-02T17:53:42.1921831Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-11-01T18:53:42.1921796Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.2246902469,58.235142854]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-10-31T18:53:42.1921842Z\",\"lastEdited\":\"2024-11-02T16:53:42.1921842Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-31T18:53:42.1921838Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33703537035,58.352714281]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-30T18:53:42.1921847Z\",\"lastEdited\":\"2024-11-02T15:53:42.1921848Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-30T18:53:42.1921844Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.4493804938,58.470285708]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-29T18:53:42.1921909Z\",\"lastEdited\":\"2024-11-02T14:53:42.1921909Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-29T18:53:42.1921905Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.56172561725,58.587857135]},\"properties\":{\"id\":5,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-28T18:53:42.1921914Z\",\"lastEdited\":\"2024-11-02T13:53:42.1921915Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-28T18:53:42.1921911Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.6740707407,58.705428562]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-27T18:53:42.1921921Z\",\"lastEdited\":\"2024-11-02T12:53:42.1921921Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "2024-10-27T18:53:42.1921918Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.78641586415,58.822999989]},\"properties\":{\"id\":7,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-26T18:53:42.1921926Z\",\"lastEdited\":\"2024-11-02T11:53:42.1921926Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Sattelitt\"}", "2024-10-26T18:53:42.1921923Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.8987609876,58.940571416]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-25T18:53:42.1921931Z\",\"lastEdited\":\"2024-11-02T10:53:42.1921931Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-25T18:53:42.1921928Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01110611105,59.058142843]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-24T18:53:42.1921936Z\",\"lastEdited\":\"2024-11-02T09:53:42.1921936Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "2024-10-24T18:53:42.1921933Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234512345,59.17571427]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-23T18:53:42.1921942Z\",\"lastEdited\":\"2024-11-02T08:53:42.1921943Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "2024-10-23T18:53:42.1921939Z" });
        }
    }
}
