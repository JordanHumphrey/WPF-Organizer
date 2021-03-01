# WPF-Organizer
WPF Application that uses Entity Framework, Prism Event Aggregator, UI, Model and DataAccess project layers to build a client-server application that adheres to MVVM.

1. [x] Define Architecture
2. [x] Build Basic UI layer
3. [x] Setup Entity Framework
   - [x] Plan Data Access Layer
   - [x] Create a DbContext subclass
   - [x] Add code first migration
   - [x] Create and seed database
   - [x] Build Friend Data Service
   - [x] Load Data Async
4. [x] Decouple UI parts
   - [x] Create Lookup Data Service
   - [x] Create Navigation ViewModel
   - [x] Create Navigation View
   - [x] Create Friend Detail ViewModel
   - [x] Create Friend Detail View 
5. [x] Communication between View Models
   - [x] Plan View Model Communication
   - [x] Add Prism's Event Aggregator
   - [x] Publish OpenFriendDetail event
   - [x] Subscribe to OpenFriendDetail event
6. [x] Saving Data
   - [x] Save command with ICommand
   - [x] Save Friend with Entity Framework
   - [x] Update Navigation view after save
   - [x] Add Navigation View Item
7. [ ] Validate User Input
8. [ ] Detecting Model Changes
9. [ ] Adding and Deleting Entities
10. [ ] Lookups
11. [ ] Object Graphs
12. [ ] Support Other Detail Views
13. [ ] Tabbed UI
14. [ ] Detail View for Collections
15. [ ] Implement Optimistic Concurrency
16. [ ] Final Styling of UI
