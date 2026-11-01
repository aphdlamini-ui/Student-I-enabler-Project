# Student Help iEnabler

A Windows Forms desktop application that simulates a university student self-service portal. Built in **C# (.NET Framework 4.7.2)** by the **Code Academy Group** (six students) for the **ISTN2IP** module. I was the **group leader**, and the project earned **76%**.

> **Note:** This is a prototype. All student data, marks and fees are simulated, and no real student information is stored or used. Nothing is connected to a database.

## Features

| Area | What it does |
|---|---|
| **Login** | Student number and password validation, masked password with a show/hide toggle, simulated "forgot password" flow |
| **Dashboard** | Shows student name, phone number, registered-module count, year of study and total amount due |
| **Module registration** | Pick modules with live credit tracking (16 credits per module, 160-credit cap) and automatic fee calculation |
| **First-year registration** | Separate flow with a required 128 credits (8 modules) and its own fee structure |
| **Class marks** | Calculates the DP (duly performed) mark from tests and shows whether the student is granted an exam, must appeal, or is denied |
| **Exam marks** | Displays exam marks with performance feedback (distinction, great, average, failed) |
| **Final marks** | Combines DP and exam marks (50/50) and shows the result per module with a pass, supplementary or fail outcome |
| **Module guide** | Reference screen for module information |
| **Update details** | Edit phone number with input validation (exactly 10 digits) and a double-confirmation dialog |
| **Support** | In-app "contact support" message dialog |

## Tech stack

- C# / .NET Framework 4.7.2
- Windows Forms (WinForms)
- Visual Studio (solution and project files included)
- `Microsoft.VisualBasic` (used for `InputBox` dialogs)

## Getting started

**Requirements:** Windows and Visual Studio 2019 or newer with the ".NET desktop development" workload.

1. Clone the repository
2. Open `Student Help iEnabler 2.sln` in Visual Studio
3. Press **F5** to build and run

**Demo login**

| Field | Value |
|---|---|
| Student number | `12345678` |
| Password | `demo123` |

**Troubleshooting**

- *"Couldn't process file FormX.resx because it is in the internet or restricted zone":* Windows blocks files downloaded from the internet. In Visual Studio open **View → Terminal** and run `Get-ChildItem -Recurse | Unblock-File`, then rebuild.
- *Solution Explorer shows empty files or the app won't run:* close Visual Studio, make sure you **extracted** the whole folder (don't open it from inside the zip), then double-click `Student Help iEnabler 2.sln` and run again.
- *"Could not find .NET Framework 4.7.2":* install the 4.7.2 Developer Pack, or retarget the project to a newer .NET Framework 4.x in the project properties.
- *App won't start on Mac or Linux:* it's a Windows Forms app, so it needs Windows.
- Visual Studio 2022 or newer is recommended. Close other heavy applications if the app feels slow.

## Project structure

```
Student Help iEnabler 2/
├── Program.cs        # Entry point (launches the login form)
├── AppData.cs        # Shared in-memory student state
├── Form1.cs          # LoginForm
├── Form2.cs          # MenuForm (dashboard)
├── Form3.cs          # ModuleRegistration
├── Form4.cs          # FirstYearRegistrationForm
├── Form5.cs          # ExamMarkForm
├── Form6.cs          # ClassMarkForm
├── Form7.cs          # UpdateDetailsForm
├── Form8.cs          # ModuleGuideForm
├── Form9.cs          # FinalMarkForm
└── Resources/        # Images and logos
```

## How we built it

We followed the **Waterfall** approach (analysis, design, build, test), where each stage is finished before the next begins. Before writing code we produced a **System Analysis Report** and a **GUI Report**, which covered:

- **Problems in the existing student iEnabler system:** fragmented navigation, rigid module limits, manual approvals and little guidance for first-year students
- **CRUD analysis** of the Student data entity to identify use cases (add login details, look up information, update details, archive accounts)
- **Functional and non-functional requirements**, plus validation rules for logins and module selection
- **Interface design** covering login, registration, viewing marks, updating details, the student menu and navigation (Previous and Restart buttons)

The app is event-driven: button clicks trigger methods that control navigation, data and feedback. A shared static `AppData` class stores student information so every form can read it without passing data around.

## My role

As **group leader** of a six-person team, I:

- Led the team through the full project lifecycle using the Waterfall approach, from the system analysis and GUI reports through to the finished application
- Coordinated how the nine forms and the shared `AppData` class were divided up, so everyone's screens fitted together into one solution
- Integrated and tested the final build, and wrote troubleshooting steps for common Visual Studio problems (blocked downloaded files, extraction issues) so the project runs on other machines
- Coordinated the final submission: the system analysis report, GUI documentation, peer evaluation and run instructions

## What I learned

- Building multi-form desktop applications and passing state between forms
- Input validation and user-friendly error handling
- Applying business rules (credit limits, fee calculation, mark thresholds) in code
- Working in a team: dividing work, integrating each other's code and meeting deadlines

## Possible improvements

- Replace hard-coded demo credentials and marks with a database (for example SQL Server or SQLite)
- Hash passwords instead of comparing plain text
- Move duplicated mark-calculation logic into shared helper classes
- Persist registration and updated details between sessions

## Team

**Code Academy Group**, ISTN2IP group project

- Thabane Dlamini (Group Leader)
- Hlalembusweni Xulu
- Phumelele Mathebula
- Dineo Mtolo
- Thulisile Thango
- Asabonga Ngunze
