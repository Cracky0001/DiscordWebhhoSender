# Discord Webhook Sender
A simple GUI program for sending Discord Webhooks.

## Features
- Input of webhook URL through a textbox
- Input of title, description, and URL for the embed through textboxes
- Automatic creation of embed timestamps
- Sending of the webhook and display of the Discord server's response as a pop-up message
## Usage
1. Input the webhook URL in the "Webhook URL" textbox.
2. Input the title, description, and URL for the embed in the corresponding textboxes.
3. Click the "Send" button to send the webhook.
4. The Discord server's response will be displayed as a pop-up message.
## Notes
- Make sure you have a valid webhook URL and the required permissions for sending webhooks.
-The embed color scheme is specified as a 32-bit ARGB value (alpha-red-green-blue). A value of 0 represents transparent, while a value of 16777215 (0xFFFFFF) represents white. 
- The timestamp is created in ISO-8601 format and represents the current time on the user's system.
