# Digital Petty Cash Ledger System

## Overview

A Petty Cash system is used by businesses to manage small, incidental expenditures such as tea, stationery, or taxi fares using an imprest (float) fund.

This project implements a **Digital Petty Cash Ledger System** using **C#**, demonstrating **Object-Oriented Programming**, **Generics**, and **type-safe in-memory data handling** without using any external database or file storage.

---

## Objective

The objective of this project is to verify the ability to:

- Apply Encapsulation and Abstraction using clear data models
- Use Inheritance to differentiate transaction types
- Implement Generics for reusable, type-safe ledgers
- Use Collections for efficient storage and filtering
- Demonstrate Polymorphism using a common interface
- Build scalable and maintainable financial software

---

## Technical Requirements

### A. Data Model (OOP)

#### Abstract Class: Transaction
**Properties**
- Id
- Date
- Amount
- Description

#### Derived Classes
- **ExpenseTransaction**
  - Additional Property: Category (Office, Travel, Food)
- **IncomeTransaction**
  - Additional Property: Source (Main Cash, Bank Transfer)

#### Interface
- **IReportable**
  - Method: `GetSummary()`
 
### B. Ledger Logic (Generics & Collections)

#### Generic Class

    
#### Storage
- Internal `List<T>` to store transaction history

#### Methods
- `AddEntry(T entry)`
- `GetTransactionsByDate(DateTime date)`
- `CalculateTotal()`

---

### C. Technical Restrictions

- In-memory storage only
- No SQL or file I/O
- Strong compile-time type safety
- Only Transaction-derived objects allowed in Ledger

---

## Use Case Definition

### Use Case ID
UC-FIN-01

### Use Case Name
Record and Balance Petty Cash

### Actor
Petty Cash Custodian

### Pre-condition
The application is running and ledgers for Income and Expenses are initialized.

---

## Main Success Scenario

1. Create `Ledger<IncomeTransaction>` to track funds received
2. Record an income of $500 from "Main Cash"
3. Create `Ledger<ExpenseTransaction>` to track expenses
4. Record:
   - $20 for Stationery
   - $15 for Team Snacks
5. Calculate totals from both ledgers
6. Compute Net Balance (Total Income - Total Expenses)

---

## Expected Output

Received: $500
Spent : $35
Net Balance: $465

[Income] 07-01-2026 | Main Cash | $500 | Petty cash
[Expense] 07-01-2026 | Stationery | $20 | Pencil
[Expense] 07-01-2026 | Team Snacks | $15 | Food

---



---

## Compile-Time Type Safety

Attempting to add an `IncomeTransaction` to a `Ledger<ExpenseTransaction>` results in a compile-time error, proving generic constraints and type safety.

---

## Polymorphism Demonstration

A `List<Transaction>` can iterate through both Income and Expense transactions and invoke `GetSummary()` dynamically for each object.

---

## Algorithm

1. Initialize income and expense ledgers
2. Add income transactions
3. Add expense transactions
4. Calculate total income
5. Calculate total expenses
6. Compute and display net balance
7. Display transaction summaries

---

## Software Architecture

- Layered design with separation of concerns
- Generic Ledger for scalability
- Abstract base class for extensibility
- Interface-driven reporting
- In-memory data processing

---

## Deliverables

- Algorithm
- Class Diagram (Draw.io)
- C# Source Code
- Generic Ledger Implementation
- README Documentation

---

## Conclusion

This project demonstrates a professional understanding of C# OOP principles, generic programming, and type-safe architecture. The design ensures scalability, maintainability, and reduced runtime errors, making it suitable for real-world financial tracking systems.

---

