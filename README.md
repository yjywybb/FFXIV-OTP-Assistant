# FFXIV OTP Assistant

### Introduction:
A tool for [ffxivlauncher](https://github.com/goatcorp/FFXIVQuickLauncher) automatically sending one-time password to http://127.0.0.1:4646/ffxivlauncher/.

### usage:
FFXIV OTP Assistant.exe "*Raw data*"  
Replace *Raw data* with your own *secert from otpauth link* or *data from otpauth-migration link*.

### Example:
+ otpauth://totp/Square%20Enix%20ID:testid?secret=**XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX** (32 letters or numbers)
+ otpauth-migration://offline?data=**xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx** (Indefinite length, typically longer than 32 characters)
