ure# Part 1: Cybersecurity Awareness Chatbot 

## Overview
The **Cybersecurity Awareness Chatbot** is a C# console application developed using **.NET 8**.  
The purpose of this chatbot is to educate users about common cybersecurity threats such as phishing attacks, weak passwords, and unsafe browsing practices.

The chatbot interacts with users through a simple conversational interface and provides guidance on how to stay safe online. This project forms part of a **Programming Portfolio of Evidence (POE)** and demonstrates concepts such as user input, string manipulation, console UI design, and structured programming.

---

## Objectives
The main objectives of this project are to:

- Develop a **console application that interacts with users**
- Implement **string manipulation for chatbot responses**
- Use **automatic properties in C#**
- Improve console applications using **ASCII art and colour formatting**
- Implement **voice greeting functionality**
- Practice **GitHub version control and Continuous Integration**

---

## Features

### 1. Voice Greeting
When the chatbot launches, it plays a **voice greeting (WAV file)** to welcome the user.

Example greeting:
```
Hello! Welcome to the SecureWin.
I'm here to help you stay safe online.
```

---

### 2. ASCII Art Logo
The chatbot displays an **ASCII cybersecurity-themed logo** when the program starts.

This improves the visual appearance of the console interface.

---

### 3. Personalised User Interaction
The chatbot asks the user for their name and uses it to personalise responses.

Example:

```
Please enter your name: Erwin

Hello Erwin!
Welcome to the Cybersecurity Awareness Bot.
```

---

### 4. Cybersecurity Chatbot Responses
The chatbot can answer basic cybersecurity questions including:

- How are you?
- What is your purpose?
- What can I ask you about?
- Password safety
- Phishing attacks
- Safe browsing

Example interaction:

```
You: What is phishing?

Bot: Phishing is when attackers trick you into revealing personal
information through fake emails or websites.
```

---

### 5. Input Validation
The chatbot detects invalid input such as:

- Empty messages
- Unsupported questions

Example:

```
Bot: I didn’t quite understand that. Could you rephrase?
```

---

### 6. Enhanced Console User Interface
The application uses:

- Console colours
- Decorative borders
- ASCII art
- Structured text layout

This improves readability and user experience.

---

## Technologies Used

- **C#**
- **.NET 8 Console Application**
- **System.Media (SoundPlayer)**
- **GitHub**
- **GitHub Actions (CI)**

---

## Project Structure

```
CyberSecurityAwarenessBot
│
├── Program.cs
│
├── Classes
│   ├── ChatBot.cs
│   ├── Responses.cs
│   ├── VoicePlayer.cs
│   └── UIHelper.cs
│
├── Audio
│   └── hello.wav
│
└── README.md
```

### File Descriptions

| File | Description |
|-----|-------------|
| Program.cs | Entry point of the application |
| ChatBot.cs | Handles user interaction and chatbot logic |
| Responses.cs | Contains chatbot responses to user questions |
| VoicePlayer.cs | Plays the welcome voice message |
| UIHelper.cs | Displays ASCII art and console UI formatting |
| hello.wav | Audio greeting file |

---

## How to Run the Project

### Requirements
- Visual Studio 2022 or later
- .NET 8 SDK installed

---

### Steps to Run

1. Clone the repository

```
git clone https://github.com/yourusername/CyberSecurityAwarenessBot.git
```

2. Open the project in **Visual Studio**

3. Build the project

```
Build → Build Solution
```

4. Run the program

```
Ctrl + F5
```

---

## Example Output

```
========================================
      CYBERSECURITY AWARENESS BOT
========================================

Please enter your name: Erwin

Hello Erwin!
Welcome to the Cybersecurity Awareness Bot.

You: What is phishing?

Bot: Phishing is when attackers trick you into revealing personal
information through fake emails or websites.
```

---
<img width="1900" height="705" alt="image" src="https://github.com/user-attachments/assets/c8c69294-d60b-43ed-8a71-86bfbf5dadac" />


## Future Improvements

### Part 2
- Convert the chatbot to a **GUI application**
- Use **Windows Forms or WPF**
- Improve topic recognition

### Part 3
- Add **interactive cybersecurity activities**
- Create a **cybersecurity tips task list**
- Add **simple games for user engagement**

---

## Author

**Name:** Erwin Mashobane  
**Student number:** ST10073464 
**Module:** PROG6221/w  
**Project:** Cybersecurity Awareness Chatbot  

---

## License

This project was developed for **educational purposes** as part of a university assignment.
