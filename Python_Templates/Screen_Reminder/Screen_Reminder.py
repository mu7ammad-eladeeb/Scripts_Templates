import time
from plyer import notification

if __name__ == "__main__":
    while True:
        time.sleep(3600)
        notification.notify(
            title="ALERT!!!",
            message="Take a break! It has been an hour!",
            timeout=10
        )
