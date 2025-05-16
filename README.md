# 367-project-repo-erindestroyerofevil
367-project-repo-erindestroyerofevil created by GitHub Classroom
Project for CS367. Will include a workout generation and tracker.
Thus far I am the only team member in this group. Erin Anderson
My project is a Personalized Workout Generator that builds weekly workout plans tailored to user goals, available equipment, and schedule. It includes adaptive logic to adjust plans based on user performance and missed sessions. The app helps users stay consistent with their fitness journey through smart planning and tracking.
My domain objects will be:
  -A user profile that stores user information, fitness goals, equipment, and schedule.
  -A workout plan that will be a multi-day workout plan tailored to a user's profile.
  -A workout session that contains exercises, sets, and reps.
  -Exercise that includes name, muscle group, equipment needed, difficulty level.
  -A performance log that tracks user feedback and results from completed sessions.
The data that will persist is: 
  User profiles and preferences
  Generated workout plans and sessions
  Exercise library (fetched from API and cached locally)
  User performance logs and session history  
The online service I plan on using is the  [ExerciseDB API](https://rapidapi.com/justin-WFnsXH_t6/api/exercisedb)  to fetch real world data about equipment type, target muscles and directions.
