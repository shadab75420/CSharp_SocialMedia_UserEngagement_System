# C# Social Media User Engagement System

## Problem Statement

This project simulates a Social Media User Engagement System using C# collections.
It manages users, posts, likes, notifications, and recent actions to demonstrate real-world usage of data structures.

---

## Features

* Add and manage unique users
* Create and store posts
* Like posts and track like counts
* Undo last action using stack
* Process notifications using queue
* Display users, posts, and activity history

---

## Technologies Used

* C#
* .NET
* Collections (List, Dictionary, HashSet, Stack, Queue)

---

## Data Structures Used

* **List<string>** → Stores all posts
* **Dictionary<string, int>** → Tracks likes per post
* **HashSet<int>** → Maintains unique user IDs
* **Stack<string>** → Tracks recent actions (Undo feature)
* **Queue<string>** → Processes notifications (FIFO)

---

## Functionality Overview

### User Management

* Ensures unique users using HashSet
* Prevents duplicate user IDs

### Post Management

* Adds posts to a list
* Initializes likes for each post

### Like System

* Updates like count using Dictionary
* Records actions and notifications

### Undo Feature

* Uses Stack to remove the most recent action (history-based undo)

### Notifications

* Uses Queue to process notifications in order

---

## Sample Output

User 1 already exists.
Undo: Post liked: Excited about the new tech release!

Processing Notifications:

New post created: Just finished my morning run!

New post created: Excited about the new tech release!

Post liked: Just finished my morning run!

Post liked: Just finished my morning run!

Post liked: Excited about the new tech release!

Users:
User ID: 1
User ID: 2

Posts and Likes:
Just finished my morning run! - Likes: 2
Excited about the new tech release! - Likes: 1

Recent Actions:

User 1 added

User 2 added

Post added: Just finished my morning run!

Post added: Excited about the new tech release!

Post liked: Just finished my morning run!

Post liked: Just finished my morning run!

---

## How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the program (Ctrl + F5)

---

## Key Concepts

* C# Collections
* Data Structures (List, Dictionary, HashSet, Stack, Queue)
* FIFO & LIFO principles
* Real-world system simulation

---

## Limitations

* Undo feature only removes action from history and does not reverse actual data
* No user input (predefined execution in Main method)


CSharp_SocialMedia_UserEngagement_System
