# 367-Project-Repo-Destroyersofevil

**Team Members:**
- Areli
- Erin
- Philip S


**Project Overview**

For this project will include a fitness goal tracker with a personalized workout generation and tracker that builds weekly personalized workout plans tailored to user goals, available equipment, and schedule. It includes adaptive logic to adjust plans based on user performance and missed sessions based on thr information found at the progress tracking history. The app helps users stay consistent with their fitness journey through smart planning and tracking.

**Domain objects:**

- User profile: Stores user information, fitness goals, equipment, and schedule.
- Workout plan: Will be a multi-day workout plan tailored to a user's profile.
- Workout session: Contains exercises, sets, and reps, and performance data.
- Exercise: Includes name, muscle group, equipment needed, difficulty level.
- Performance log: Tracks user feedback and results from completed sessions.
- Goal: Represents a user's fitness objective (e.g., weight loss, muscle gain, improved endurance).


**Data that will persist:**

- User Data: User profiles and preferences (name, age, gender, height, weight, activity level, fitness goals, schedule, available equipment, etc.)
- Workout Plan Data: Generated workout plans and sessions, including plan details, associated workouts, frequency, duration, etc.
- Exercise Data: Exercise library (name, muscle group, equipment needed) fetched from API and cached locally
- Performance Data: User performance logs and session history  
- Goal Data: User fitness goals (type, started dates, target values, status, etc.)

**Online Service we will use**

The online service we plan on using is the  [ExerciseDB API](https://rapidapi.com/justin-WFnsXH_t6/api/exercisedb)  to fetch real world data about equipment type, target muscles and directions.

**GitHub Repository**

Here is the URL to our [GitHub Repository](https://github.com/wou-cs-cander/367-project-repo-destroyersofevil)