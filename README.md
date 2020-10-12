# What is this project about

This is sample project I use to teach people of team work with git tool. It conatins simple mathematical problem that can be fast implemented. 
The goal is to simulate parallel team work, playing with forks, PR, merges etc.

# MathAPI endpoints to implement

1. Head to [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/3.1) and install SDK 3.1.
2. Verify your installation by running command ` dotnet --version` in your terminal of choice. If .NET Core installed correctly you should get relevant information.
3. Run `dotnet restore` to pull all dependencies
4. Run `dotnet run` to start application. It will run on default port `5000` You should get proper logs indication application is listening for requests.
5. perform GET request as follows `curl -s http://localhost:5000/math/add/2.32/4.23`

# What is this task about 

There need to be following apis method implemented:
1. HTTP GET /math/fib/:n - calculate [Fibbonacci series](https://en.wikipedia.org/wiki/Fibonacci_sequence) n-element
2. HTTP GET /math/first-lowest-prime/:n - calculate closest [prime nunber](https://en.wikipedia.org/wiki/Prime_number)-p such p<=n
3. HTTP GET /math/gdc/:a/:b - [calculate grates common divisior](https://en.wikipedia.org/wiki/Greatest_common_divisor) 
4. HTTP GET /math/lcm/:a/:b - [least common multiple](https://en.wikipedia.org/wiki/Least_common_multiple)
5. HTTP GET /math/convex-polygon-diagonals/:n - calculate number of [diagonals of flat convex polygon](https://tutors.com/math-tutors/geometry-help/diagonal-formula)
6. HTTP GET /math/binominal/:n/:k - k-element combination out of n-eleemnt set without repetition, called also [binominal coefficient](https://en.wikipedia.org/wiki/Binomial_coefficient)
7. HTTP GET /math/factorial/:n - calculate [the factorial](https://en.wikipedia.org/wiki/Factorial) of n number 
8. HTTP GET /math/circle-params/:r - for given real number calculate circle field and circuit
9. HTTP GET /math/random-between/:a/:b - for given range [a,b] return random number with equal distribution i.e. (b-a)*P([a,b]) = 1

# Response shape

The response should be JSON object consisting of provided parameters and result of calculation.

# Responses and data validation

All input data should be validated within conroller body and for invalid parameters 400 Bad Request shoult be returned to client.

# Contributing guidlines

1. Please fork this to your account.
2. Please never commit build and project dependencies files.
3. Please work on topic branch.
4. Please provide your commit in atomic manner. Each small changes should be commited separetely. 
5. Please provide meaningful name of commit.
6. Please use [this](https://udacity.github.io/git-styleguide/) convention of commiting.
7. Please put logic into separate module. Exapmle of module is in `add.js` file.
8. Please put endpoint definition into `index.js`.
