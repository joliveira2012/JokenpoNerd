# JokenpoNerd
Jokenpo for 2 players

This is a Jokenpo Nerd Game by API

# How can play

POST:
https://localhost:44379/api/Jokenpo

Put your name in "name"
Put one Symbol in "symbol" - [Rock, Paper, Scissors, Lizard, Spock]

BODY:
[
  {
    "name":"jg1",
    "symbol":"lizard"
  },
  {
    "name":"jg2",
    "symbol":"spock"
  }
]

I suggest https://reqbin.com/ to test the api or Postman, 
To fix in postman go to the Settings -> General and turn off SSL certificate verification.
