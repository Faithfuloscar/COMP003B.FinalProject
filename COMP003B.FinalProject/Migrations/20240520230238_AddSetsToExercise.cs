using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddSetsToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Record_Exercises_ExerciseId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_FitnessGoal_FitnessGoalId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Location_LocationId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Session_SessionId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Users_UserId",
                table: "Record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Record",
                table: "Record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FitnessGoal",
                table: "FitnessGoal");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "Record",
                newName: "Records");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "FitnessGoal",
                newName: "FitnessGoals");

            migrationBuilder.RenameIndex(
                name: "IX_Record_UserId",
                table: "Records",
                newName: "IX_Records_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_SessionId",
                table: "Records",
                newName: "IX_Records_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_LocationId",
                table: "Records",
                newName: "IX_Records_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_FitnessGoalId",
                table: "Records",
                newName: "IX_Records_FitnessGoalId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_ExerciseId",
                table: "Records",
                newName: "IX_Records_ExerciseId");

            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "Locations",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Sessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "SessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FitnessGoals",
                table: "FitnessGoals",
                column: "FitnessGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_LocationId",
                table: "Sessions",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Exercises_ExerciseId",
                table: "Records",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_FitnessGoals_FitnessGoalId",
                table: "Records",
                column: "FitnessGoalId",
                principalTable: "FitnessGoals",
                principalColumn: "FitnessGoalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Locations_LocationId",
                table: "Records",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Sessions_SessionId",
                table: "Records",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Locations_LocationId",
                table: "Sessions",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Exercises_ExerciseId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_FitnessGoals_FitnessGoalId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Locations_LocationId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Sessions_SessionId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Locations_LocationId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_LocationId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FitnessGoals",
                table: "FitnessGoals");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Sessions");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Record");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "FitnessGoals",
                newName: "FitnessGoal");

            migrationBuilder.RenameIndex(
                name: "IX_Records_UserId",
                table: "Record",
                newName: "IX_Record_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_SessionId",
                table: "Record",
                newName: "IX_Record_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_LocationId",
                table: "Record",
                newName: "IX_Record_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_FitnessGoalId",
                table: "Record",
                newName: "IX_Record_FitnessGoalId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_ExerciseId",
                table: "Record",
                newName: "IX_Record_ExerciseId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Location",
                newName: "LocationName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "SessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Record",
                table: "Record",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FitnessGoal",
                table: "FitnessGoal",
                column: "FitnessGoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Exercises_ExerciseId",
                table: "Record",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_FitnessGoal_FitnessGoalId",
                table: "Record",
                column: "FitnessGoalId",
                principalTable: "FitnessGoal",
                principalColumn: "FitnessGoalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Location_LocationId",
                table: "Record",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Session_SessionId",
                table: "Record",
                column: "SessionId",
                principalTable: "Session",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Users_UserId",
                table: "Record",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
