# README

# Screen Reminder

A simple Python application that sends periodic desktop notifications to remind you to take breaks while working. Built using Python and the `plyer` library.

---

## Features

- **Automated Alerts:** Sends pop-up desktop notifications at custom time intervals.
- **Cross-Platform:** Works on Windows, macOS, and Linux via `plyer`.
- **Lightweight:** Runs seamlessly in the background with minimal system resources.

---

## Installation

1. **Clone the repository:**
git clone [https://github.com/mu7ammad-eladeeb/Screen_Reminder.git](https://github.com/mu7ammad-eladeeb/Screen_Reminder.git)
cd Screen_Reminder
2. **Install required dependencies:**
pip install -r requirements.txt

---

## Usage

Run the script using Python:

python Screen_Reminder.py

To stop the script, press Ctrl + C in your terminal window.

---

## Customization

You can adjust the interval between notifications by editing the time.sleep() parameter in Screen_Reminder.py:

# For notifications every 1 hour (3600 seconds)

time.sleep(3600)

---

## License

This project is licensed under the MIT License.