# Workoutapp
Individuell inlämningsuppgift

Träningspass API
Beskrivning
Detta projekt handlar om att utveckla ett API för att hantera träningspass. Jag har skapat ett klassbibliotek som inkluderar olika typer av träningspass och implementerat funktioner för att filtrera och sortera dessa pass. Därutöver har jag byggt endpoints för att effektivt hantera och visa information om träningspassen.

Klasser
Workout: En bas-klass för träningspass som har egenskaper som Id, Namn, Datum, Längd (i minuter) och Förbrända kalorier.
CardioWorkout: Ärver från Workout och lägger till egenskaper som Distans (i km) och Medelhastighet (i km/h).
StrengthWorkout: Ärver också från Workout och lägger till egenskaper som Muskelgrupp och Intensitet.

Algoritmer
Jag skapade en klass som heter WorkoutFilter med metoder för att:
Filtrera träningspass efter muskelgrupp.
Sortera träningspass efter intensitet.

Endpoints
Jag har lagt till tre nya endpoints i API:t:
GET /workouts/muscle-group/{group}: Hämtar träningspass för en viss muskelgrupp.
GET /workouts/sort-by-intensity: Hämtar träningspass sorterade efter intensitet.
GET /workouts/total-calories: Beräknar det totala antalet förbrända kalorier från alla träningspass.

Testning
Jag har testat API:t med Postman och Swagger. Några exempel på hur det fungerar kommer nedan:
Skapa ett nytt träningspass: POST /workouts.
Filtrera träningspass efter muskelgrupp: GET /workouts/muscle-group/Arms.
Sortera träningspass efter intensitet: GET /workouts/sort-by-intensity?ascending=true.
Beräkna totala kalorier: GET /workouts/total-calories.

Designprinciper
Single Responsibility: Varje klass har ett tydligt ansvar.
Arv: Jag använde arv för att dela gemensamma egenskaper mellan klasser.
Inkapsling: Egenskaper är skyddade med olika åtkomstmodifierare som public, private eller protected.

