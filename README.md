# Discord Webhook Sender
Ein einfaches GUI-Programm, mit dem Sie Discord Webhooks versenden können.

## Funktionen
- Eingabe der Webhook URL über ein Textfeld
- Eingabe des Titels, der Beschreibung und der URL für das Embed über Textfelder
- Automatische Erstellung von Embed-Timestamps
- Senden des Webhooks und Anzeigen der Antwort des Discord-Servers als Popup-Meldung
## Benutzung
- Geben Sie die Webhook URL im Textfeld "Webhook URL" ein.
- Geben Sie den Titel, die Beschreibung und die URL für das Embed in den entsprechenden Textfeldern ein.
- Klicken Sie auf den Button "Senden", um das Webhook zu senden.
- Die Antwort des Discord-Servers wird als Popup-Meldung angezeigt.
## Hinweise
- Stellen Sie sicher, dass Sie über eine gültige Webhook URL verfügen und dass Sie über die erforderlichen Berechtigungen für das Senden von Webhooks verfügen.
- Das Embed-Farbschema wird als 32-Bit-ARGB-Wert (Alpha-Rot-Grün-Blau) angegeben. Der Wert 0 entspricht transparent, während der Wert 16777215 (0xFFFFFF) Weiß entspricht. (Funktion vorübergehend deaktiviert)
- Der Timestamp wird im ISO-8601-Format erstellt und entspricht der aktuellen Uhrzeit auf dem System des Benutzers.
