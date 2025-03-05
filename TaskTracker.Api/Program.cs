using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Mock-data för träningspass och övningar
var workouts = new List<Workout>();
var strengthWorkouts = new List<StrengthWorkout>();
var exercises = new List<Exercise>();

// Endpoint för att hämta alla träningspass
app.MapGet("/workouts", () => workouts);

// Endpoint för att skapa ett nytt träningspass
app.MapPost("/workouts", (Workout workout) =>
{
    workouts.Add(workout);
    return Results.Created($"/workouts/{workout.Id}", workout);
});

// Endpoint för att filtrera övningar efter muskelgrupp
app.MapGet("/workouts/muscle-group/{group}", (string group) =>
{
    var filteredExercises = WorkoutFilter.FilterExercisesByMuscleGroup(exercises, group);
    return Results.Ok(filteredExercises);
});

// Endpoint för att sortera styrketräningspass efter intensitet
app.MapGet("/workouts/sort-by-intensity", (bool ascending) =>
{
    var sortedWorkouts = WorkoutFilter.SortWorkoutsByIntensity(strengthWorkouts, ascending);
    return Results.Ok(sortedWorkouts);
});

// Endpoint för att beräkna total träningstid
app.MapGet("/workouts/total-duration", () =>
{
    var totalDuration = WorkoutFilter.CalculateTotalDuration(workouts);
    return Results.Ok(new { TotalDurationMinutes = totalDuration });
});

// Endpoint för att beräkna totalt antal förbrända kalorier
app.MapGet("/workouts/total-calories", () =>
{
    var totalCalories = WorkoutFilter.CalculateTotalCaloriesBurned(workouts);
    return Results.Ok(new { TotalCaloriesBurned = totalCalories });
});

app.Run();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Mocklista för att lagra träningspass
List<Workout> workouts = new List<Workout>();

// 1. Endpoint för att skapa ett träningspass
app.MapPost("/workouts", (Workout workout) =>
{
    // Lägg till träningspasset i listan
    workouts.Add(workout);
    return Results.Created($"/workouts/{workout.Id}", workout);  // Returnera det skapade träningspasset
});

// Kör API:et

POST /workouts
Content-Type: application/json
{
    "id": 1,
    "name": "Arm Day",
    "date": "2023-10-15",
    "durationMinutes": 60,
    "caloriesBurned": 300
};
[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(new { Message = "List of tasks" });
    }
}
