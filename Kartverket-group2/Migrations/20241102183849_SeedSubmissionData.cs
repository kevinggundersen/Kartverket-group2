using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kartverket_group2.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubmissionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Comment", "GeoJsonData", "Municipalitynr", "Status", "Timestamp" },
                values: new object[,]
                {
                    { 1L, "Test submission 1", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.1,60.1]},\"properties\":{\"id\":1,\"type\":\"Road\",\"comment\":\"Feature comment 1\",\"addedAt\":\"2024-11-01T18:38:48.8813325Z\",\"lastEdited\":\"2024-11-02T17:38:48.8813327Z\",\"radius\":10.5}}],\"activeTileLayer\":\"Topographic\"}", "3001", "Uåpnet", "2024-11-01T18:38:48.8813287Z" },
                    { 2L, "Test submission 2", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.2,60.2]},\"properties\":{\"id\":2,\"type\":\"Building\",\"comment\":\"Feature comment 2\",\"addedAt\":\"2024-10-31T18:38:48.8813339Z\",\"lastEdited\":\"2024-11-02T16:38:48.8813339Z\",\"radius\":21}}],\"activeTileLayer\":\"Topographic\"}", "3002", "Under behandling", "2024-10-31T18:38:48.8813335Z" },
                    { 3L, "Test submission 3", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.3,60.3]},\"properties\":{\"id\":3,\"type\":\"Road\",\"comment\":\"Feature comment 3\",\"addedAt\":\"2024-10-30T18:38:48.8813345Z\",\"lastEdited\":\"2024-11-02T15:38:48.8813345Z\",\"radius\":31.5}}],\"activeTileLayer\":\"Topographic\"}", "3003", "Behandlet", "2024-10-30T18:38:48.8813341Z" },
                    { 4L, "Test submission 4", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.4,60.4]},\"properties\":{\"id\":4,\"type\":\"Building\",\"comment\":\"Feature comment 4\",\"addedAt\":\"2024-10-29T18:38:48.8813350Z\",\"lastEdited\":\"2024-11-02T14:38:48.8813351Z\",\"radius\":42}}],\"activeTileLayer\":\"Topographic\"}", "3004", "Under behandling", "2024-10-29T18:38:48.8813348Z" },
                    { 5L, "Test submission 5", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.5,60.5]},\"properties\":{\"id\":5,\"type\":\"Road\",\"comment\":\"Feature comment 5\",\"addedAt\":\"2024-10-28T18:38:48.8813356Z\",\"lastEdited\":\"2024-11-02T13:38:48.8813357Z\",\"radius\":52.5}}],\"activeTileLayer\":\"Topographic\"}", "3005", "Uåpnet", "2024-10-28T18:38:48.8813353Z" },
                    { 6L, "Test submission 6", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.6,60.6]},\"properties\":{\"id\":6,\"type\":\"Building\",\"comment\":\"Feature comment 6\",\"addedAt\":\"2024-10-27T18:38:48.8813363Z\",\"lastEdited\":\"2024-11-02T12:38:48.8813364Z\",\"radius\":63}}],\"activeTileLayer\":\"Topographic\"}", "3006", "Behandlet", "2024-10-27T18:38:48.8813361Z" },
                    { 7L, "Test submission 7", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.7,60.7]},\"properties\":{\"id\":7,\"type\":\"Road\",\"comment\":\"Feature comment 7\",\"addedAt\":\"2024-10-26T18:38:48.8813369Z\",\"lastEdited\":\"2024-11-02T11:38:48.8813370Z\",\"radius\":73.5}}],\"activeTileLayer\":\"Topographic\"}", "3007", "Uåpnet", "2024-10-26T18:38:48.8813366Z" },
                    { 8L, "Test submission 8", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.8,60.8]},\"properties\":{\"id\":8,\"type\":\"Building\",\"comment\":\"Feature comment 8\",\"addedAt\":\"2024-10-25T18:38:48.8813375Z\",\"lastEdited\":\"2024-11-02T10:38:48.8813375Z\",\"radius\":84}}],\"activeTileLayer\":\"Topographic\"}", "3008", "Under behandling", "2024-10-25T18:38:48.8813372Z" },
                    { 9L, "Test submission 9", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[10.9,60.9]},\"properties\":{\"id\":9,\"type\":\"Road\",\"comment\":\"Feature comment 9\",\"addedAt\":\"2024-10-24T18:38:48.8813411Z\",\"lastEdited\":\"2024-11-02T09:38:48.8813412Z\",\"radius\":94.5}}],\"activeTileLayer\":\"Topographic\"}", "3009", "Behandlet", "2024-10-24T18:38:48.8813377Z" },
                    { 10L, "Test submission 10", "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[11,61]},\"properties\":{\"id\":10,\"type\":\"Building\",\"comment\":\"Feature comment 10\",\"addedAt\":\"2024-10-23T18:38:48.8813419Z\",\"lastEdited\":\"2024-11-02T08:38:48.8813419Z\",\"radius\":105}}],\"activeTileLayer\":\"Topographic\"}", "3010", "Under behandling", "2024-10-23T18:38:48.8813416Z" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
