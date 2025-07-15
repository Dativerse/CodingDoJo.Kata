# 🎳 Bowling

This description is based on that at **Adventures in C#: The Bowling Game**

---

## 🧩 Problem Description

Create a program that, given a valid sequence of rolls for one line of **American Ten-Pin Bowling**, produces the total score for the game.

### 🚫 What the Program Will Not Do
- It will **not check** for valid rolls.
- It will **not check** for correct number of rolls and frames.
- It will **not provide** scores for intermediate frames.

These exclusions are intentional to keep the kata light and focused. Additional features can be layered on if needed for a real-world application.

---

## 📏 Scoring Summary

Each game includes **ten frames** for the bowler.

### Frame Rules
- **Two tries per frame** to knock down all pins.
- If the bowler fails to knock down all pins:
    - Score = total pins knocked down.
- If the bowler knocks them all down in two tries:
    - Called a **spare**
    - Score = 10 + pins knocked down on the next throw.
- If the bowler knocks them all down in one try:
    - Called a **strike**
    - Score = 10 + total pins knocked down in next **two** rolls.

### Final Frame (10th)
- If it's a **spare** or **strike**, the bowler gets:
    - 1 bonus roll for a spare.
    - 2 bonus rolls for a strike.
- These bonus throws **do not repeat**, even if they knock down all pins.

### 🎯 Final Score
Total score = sum of all frame scores.

More info: [How to Score for Bowling](https://codingdojo.org/kata/Bowling/)

---

## 💡 Clues

Scoring is interesting due to **lookahead logic**:
- Frame scores can't be calculated immediately after a strike or spare.
- Must wait for bonus rolls to complete scoring.

---

## 🧪 Suggested Test Cases

| Rolls                                | Description                                      | Final Score |
|-------------------------------------|--------------------------------------------------|-------------|
| `X X X X X X X X X X X X`           | 12 rolls: 12 strikes                             | `300`       |
| `9- 9- 9- 9- 9- 9- 9- 9- 9- 9-`      | 20 rolls: 10 pairs of 9 and miss                 | `90`        |
| `5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5`    | 21 rolls: 10 spares of 5, ending with a 5 bonus  | `150`       |

---

Let me know if you'd like this turned into code comments or added into a readme-style layout for a repo!
