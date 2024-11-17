using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubmissionData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.2246902469,58.235142854]},\"properties\":{\"id\":2,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-10-31T18:53:42.1921842Z\",\"lastEdited\":\"2024-11-02T16:53:42.1921842Z\",\"radius\":21}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-31T18:53:42.1921838Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.33703537035,58.352714281]},\"properties\":{\"id\":3,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-30T18:53:42.1921847Z\",\"lastEdited\":\"2024-11-02T15:53:42.1921848Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-30T18:53:42.1921844Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.4493804938,58.470285708]},\"properties\":{\"id\":4,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-29T18:53:42.1921909Z\",\"lastEdited\":\"2024-11-02T14:53:42.1921909Z\",\"radius\":42}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-29T18:53:42.1921905Z" });

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
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.6740707407,58.705428562]},\"properties\":{\"id\":6,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-27T18:53:42.1921921Z\",\"lastEdited\":\"2024-11-02T12:53:42.1921921Z\",\"radius\":63}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-27T18:53:42.1921918Z" });

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
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[8.8987609876,58.940571416]},\"properties\":{\"id\":8,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-25T18:53:42.1921931Z\",\"lastEdited\":\"2024-11-02T10:53:42.1921931Z\",\"radius\":84}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-25T18:53:42.1921928Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.01110611105,59.058142843]},\"properties\":{\"id\":9,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-24T18:53:42.1921936Z\",\"lastEdited\":\"2024-11-02T09:53:42.1921936Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Standard\"}", "Akseptert", "2024-10-24T18:53:42.1921933Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[9.1234512345,59.17571427]},\"properties\":{\"id\":10,\"type\":\"Mark\\u00F8r\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-23T18:53:42.1921942Z\",\"lastEdited\":\"2024-11-02T08:53:42.1921943Z\",\"radius\":105}}],\"activeTileLayer\":\"Turkart\"}", "Under arbeid", "2024-10-23T18:53:42.1921939Z" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.1,60.1]},\"properties\":{\"id\":1,\"type\":\"Road\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-01T18:38:48.8813325Z\",\"lastEdited\":\"2024-11-02T17:38:48.8813327Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Topographic\"}", "2024-11-01T18:38:48.8813287Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2,60.2]},\"properties\":{\"id\":2,\"type\":\"Building\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-10-31T18:38:48.8813339Z\",\"lastEdited\":\"2024-11-02T16:38:48.8813339Z\",\"radius\":21}}],\"activeTileLayer\":\"Topographic\"}", "Under behandling", "2024-10-31T18:38:48.8813335Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.3,60.3]},\"properties\":{\"id\":3,\"type\":\"Road\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-30T18:38:48.8813345Z\",\"lastEdited\":\"2024-11-02T15:38:48.8813345Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Topographic\"}", "Behandlet", "2024-10-30T18:38:48.8813341Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.4,60.4]},\"properties\":{\"id\":4,\"type\":\"Building\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-29T18:38:48.8813350Z\",\"lastEdited\":\"2024-11-02T14:38:48.8813351Z\",\"radius\":42}}],\"activeTileLayer\":\"Topographic\"}", "Under behandling", "2024-10-29T18:38:48.8813348Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.5,60.5]},\"properties\":{\"id\":5,\"type\":\"Road\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-28T18:38:48.8813356Z\",\"lastEdited\":\"2024-11-02T13:38:48.8813357Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Topographic\"}", "2024-10-28T18:38:48.8813353Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.6,60.6]},\"properties\":{\"id\":6,\"type\":\"Building\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-27T18:38:48.8813363Z\",\"lastEdited\":\"2024-11-02T12:38:48.8813364Z\",\"radius\":63}}],\"activeTileLayer\":\"Topographic\"}", "Behandlet", "2024-10-27T18:38:48.8813361Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "GeoJsonData", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.7,60.7]},\"properties\":{\"id\":7,\"type\":\"Road\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-26T18:38:48.8813369Z\",\"lastEdited\":\"2024-11-02T11:38:48.8813370Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Topographic\"}", "2024-10-26T18:38:48.8813366Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8,60.8]},\"properties\":{\"id\":8,\"type\":\"Building\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-25T18:38:48.8813375Z\",\"lastEdited\":\"2024-11-02T10:38:48.8813375Z\",\"radius\":84}}],\"activeTileLayer\":\"Topographic\"}", "Under behandling", "2024-10-25T18:38:48.8813372Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.9,60.9]},\"properties\":{\"id\":9,\"type\":\"Road\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-24T18:38:48.8813411Z\",\"lastEdited\":\"2024-11-02T09:38:48.8813412Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Topographic\"}", "Behandlet", "2024-10-24T18:38:48.8813377Z" });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "GeoJsonData", "Status", "Timestamp" },
                values: new object[] { "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11,61]},\"properties\":{\"id\":10,\"type\":\"Building\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-23T18:38:48.8813419Z\",\"lastEdited\":\"2024-11-02T08:38:48.8813419Z\",\"radius\":105}}],\"activeTileLayer\":\"Topographic\"}", "Under behandling", "2024-10-23T18:38:48.8813416Z" });
        }
    }
}
