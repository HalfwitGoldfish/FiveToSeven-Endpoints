*Name*: Charles

*Date Revised*: 01/08/25

*Mini Challenge*: MiniChallengeFiveToSeven - Endpoints

*Description*:
 Design an API with 4 endpoints based on mini challenges from the Combine:
 each endpoint must have their own Controller file, inside a Controller folder
 Also, each one must have their own service file, inside a Service folder
 Validation is required.
 
 Endpoints:
 1. MadLib: create an endpoint that accepts multiple inputs.  Output should be a story based on those values.
 
 2. OddOrEven: create an endpoint that displays if a number entered is odd or even.
 
 3. ReverseIt (Alphanumeric): endpoint that accepts a sequence of numbers and letters then reverses them.  For example:
      - "You entered 123ABC, reversed is CBA321"
 
 4. ReverseIt (Numbers Only): endpoint that accepts a sequence of only numbers and reverses them.  Be sure to display the original characters before the reversed.  For example:
      - "You entered 12345, reversed is 54321"

*Reviewer's Name*: Thao Vang

*Peer Review*:
"Logic for everything looks good. Only thing is that I think the OddOrEven and ReveresIt(NumbersOnly) needs validation. So instead of taking in an int, you should take in a string and TryParse it to see if it is a number or not and if not user gets a message that its not a nmber. Instead of just getting a 404 or 400 error on api side."
