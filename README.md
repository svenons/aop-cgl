# Group Project: Conway's Game of Life Simulator
A project focusing on the principles of Software Design and Architecture. This project simulates Conway's Game of Life, emphasizing the use of SOLID principles for a maintainable and testable codebase.

## Objective
Develop a console application to simulate Conway's Game of Life. The application allows users to:
- Define initial grid configurations
- Observe the evolution of cell patterns over time
- Achieve data persistence through JSON files for grid configurations
- Use Git for collaborative coding and xUnit for code quality assurance

## Required Components
### ICell Interface
- Defines properties and behaviors of a single cell (state, neighbors).

### IGrid Interface
- Specifies methods for grid management and cell state updates.

### IStorage Interface
- Specifies methods for loading and saving grid data.

### Cell Class
- Implements ICell, representing an individual cell's state.

### Grid Class
- Implements IGrid, managing the grid and applying Game of Life rules.

### JsonStorage Class
- Implements IStorage, handling persistence of grid data in JSON format.

### AutomatonSimulator Class
- Manages the simulation process, applying rules to the grid over time.

### Program Class (User Interface)
- Provides a console-based UI for interaction, such as grid setup and simulation controls.

## Technical Requirements
- **Game of Life Rules**: Accurately implement the rules governing cell life, death, and reproduction.
- **Console Visualization**: Display the grid with 'O' for live cells and '.' for dead cells.
- **SOLID Principles**: Ensure the codebase adheres to SOLID design principles for maintainability and extensibility.
- **JSON Data Persistence**: Use `System.Text.Json` for managing grid configurations.
- **Exception Handling and Input Validation**: Implement robust mechanisms for user input and operational errors.
- **Git for Collaborative Coding**: Use Git for version control, emphasizing regular commits and proper workflow practices.
- **xUnit Testing**: Integrate xUnit for unit testing, covering functionalities including grid updates and data persistence.

## xUnit Testing Requirements
- **Unit Tests Setup**: Create a separate xUnit test project. Reference the main project for functionality access.
- **Cell and Grid Class Tests**: Include tests for state initialization, state updates, and rule applications.
- **JsonStorage Class Tests**: Test for correct data loading/saving and handle exceptions for invalid data.
- **Integration Testing**: Use GitHub Actions for continuous integration to run tests on commits.

## Workflow
- **Application Initialization**: Start by loading existing grid data from `grid.json` or create a new random grid.
- **Main Menu Presentation**: Offer options for grid setup, simulation control (start, pause, step), and exit.
- **Grid Setup**: Allow users to specify grid dimensions and initial states or load from a JSON file.
- **Simulation Control**: Users can step through generations, save the current state, or exit the application, with changes persistently saved to `grid.json`.

## Authors
- [@svenons](https://github.com/svenons/)

## Acknowledgements
- This exercise is part of Advanced Object-Oriented Programming on [Software Engineering at SDU](https://mitsdu.dk/en/mit_studie/bachelor/softwareengineering_bachelor_soenderborg).
- Created by [Maximus D. Kaos](https://github.com/MaxDKaos/) and [Maximilian von Zastrow](https://github.com/vzastrow).