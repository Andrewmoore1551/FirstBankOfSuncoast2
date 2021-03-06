# FirstBankOfSuncoast2

PROBLEM

- Create a banking app that allows us to make and track withdrawals and deposits in two accounts, checking and savings. Doing this through Transactions.
- Keep track of balance history by looking at all of the transactions that have been done
- The transaction will be saved in a file, using CSV format to record the data.

C R U D

- Create: (Deposit/ Withdraw) (create) a new transaction.
- Read: Transaction History
- Update: Update Checking and Savings
- Delete: Removing funds from the account (Withdraw)

EXAMPLES

- If a user deposits 10 to their savings, then withdraws 8 from their savings, then deposits 25 to their checking, they have three transactions to consider. Compute the checking and saving balance, using the transaction list, when needed. In this case, their savings balance is 2 and their checking balance is 25.

- I go to the bank and check my balances for both my Savings and Checking accounts.

- I go to the bank and try to withdraw $30, but I only have $12 cause I’m broke. The bank doesn’t give me $30. They suck.

- I request a list of my transactions from my Savings and Checking accounts.

- My accounts can never go negative.

- I go to the bank and deposit $10 into my checking account. Withdraw $5 from $20 in Savings and deposit $3 back into Checking. That is 3 transactions. I have $13 in checking left and $15 in savings left

- Deposits 20 to checking, deposits 20 to savings, withdraws 12 from checking. 3 Transactions, 8 in checking 20 in savings

- Deposits 30 to savings, Deposits 45 to checking, withdraws 40 from savings. The system does not allow me to overdraft. So 2 transactions, 30 in savings and 45 in checking

| Type     | Account  | Amount |
| -------- | -------- | ------ |
| Deposit  | Savings  | 20     |
| Deposit  | Savings  | 2000   |
| Deposit  | Checking | 3000   |
| Withdraw | Checking | 42     |

Data Structure

- Create a Class called Transaction

- Properties:  
  -- Amount (int): (how much is in the transaction)
  -- Type (string): Deposit, Withdraw
  -- TimeStamp (DateTime)
  -- Account (string): Checking, Savings

- Add a List<Transactions>

Algorithm

1. Welcome to the app
2. Class Transaction// List of Transaction
3. App Should load past transactions from a file when it first starts (fileReader)
4. While the User hasn’t chosen to QUIT: (Bool is false)
5. Display the Menu Options:
   Deposit
   Withdraw
   Balance
   Transaction History
   Quit

   Ask the user what they would like to choose?

6. If (Deposit):
   Ask the user if they would like to choose Savings or Checking?
   Answer=Account
   Ask how much they want to input into savings?
   Answer=Amount
   Add a new instance of Transaction:
   Account
   Amount
   Type
   TimeStamp
   Add Transaction

   Write all the transactions to the file (the four lines of code for the fileWriter)

7. If (Withdraw):
   Ask the user if they would like to choose Savings or Checking?

   If (Savings)
   Filter Out Savings
   Filter Out the Deposit and Sum the Total of the Deposit
   Filter Out the Withdraw and Sum the Total of the Withdraw
   difference= Deposit Amount - Withdraw Amount
   Ask how much they want to withdraw from savings?
   If (difference < Asking Amount)
   Say "No funds"
   If (difference > Asking Amount)
   Add a new instance of Transaction:
   Account
   Amount
   Type
   TimeStamp
   Add Transaction
   Write all the transactions to the file (the four lines of code for the fileWriter)

   If (Checking)
   Filter Out Checking
   Filter Out the Deposit and Sum the Total of the Deposit
   Filter Out the Withdraw and Sum the Total of the Withdraw
   difference= Deposit Amount - Withdraw Amount
   Ask how much they want to withdraw from savings?
   If (difference < Asking Amount)
   Say "No funds"
   If (difference > Asking Amount)
   Add a new instance of Transaction:
   Account
   Amount
   Type
   TimeStamp
   Add Transaction
   Write all the transactions to the file (the four lines of code for the fileWriter)

8. If (Transaction History)
   Ask the user if they would like to choose Savings or Checking?
   If (Savings)
   Filter Out the Account by Savings
   Foreach(var save in savings)
   Print out your transaction history for savings
   If (Checking)
   Filter Out the Account by Checking
   Foreach(var save in savings)
   Print out your transaction history for savings

9. If (Balance)
   Ask the user if they would like to choose Savings or Checking?
   If (Savings)
   Filter Out Savings
   Filter Out the Deposit and Sum the Total of the Deposit
   Filter Out the Withdraw and Sum the Total of the Withdraw
   difference= Deposit Amount - Withdraw Amount
   Print out the difference
   If (Checking)
   Filter Out Checking
   Filter Out the Deposit and Sum the Total of the Deposit
   Filter Out the Withdraw and Sum the Total of the Withdraw
   difference= Deposit Amount - Withdraw Amount
   Print out the difference

10. If (Quit)
    Bool is True

11. Say Goodbye
