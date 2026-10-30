# Chapter 3 – Making Decisions (Visual C#)

A plain-language summary of Chapter 3 from *Starting Out with Visual C#* (Gaddis, 6th Edition). Every concept is explained in simple words, without code.

**More resources in this repo**

- [`EXAMPLES.md`](EXAMPLES.md) – code examples for every topic
- [`README_DETAILED.md`](README_DETAILED.md) – detailed notes with syntax and code

## Contents

1. [The `if` Statement](#1-the-if-statement)
2. [The `if-else` Statement](#2-the-if-else-statement)
3. [Nested and `if-else-if`](#3-nested-and-if-else-if)
4. [Logical Operators](#4-logical-operators)
5. [`bool` and Flags](#5-bool-and-flags)
6. [Comparing Strings](#6-comparing-strings)
7. [`TryParse`](#7-tryparse)
8. [Input Validation](#8-input-validation)
9. [RadioButton and CheckBox](#9-radiobutton-and-checkbox)
10. [The `switch` Statement](#10-the-switch-statement)
11. [ListBox](#11-listbox)
12. [Quick Summary](#12-quick-summary)

---

## 1. The `if` Statement

The program checks a condition. If it is **true**, it does something; if it is **false**, it skips it.

> Example: if it is raining, wear a coat.

## 2. The `if-else` Statement

This has **two paths**. If the condition is true, it takes one path; if false, it takes the other.

> Example: if your score is 50 or more, show "Pass"; otherwise, show "Fail".

## 3. Nested and `if-else-if`

- **Nested** means an `if` inside another `if`.
  > Example: first check the salary, and if it is enough, then check the years on the job.
- **`if-else-if`** checks several conditions in order. The first true one runs and the rest are skipped.
  > Example: grades A, B, C, D, F.

## 4. Logical Operators

| Operator | Name | Meaning |
|----------|------|---------|
| `&&` | AND | Both conditions must be true |
| `\|\|` | OR | At least one condition must be true |
| `!` | NOT | Flips true to false and false to true |

## 5. `bool` and Flags

- A **`bool`** stores one value: `true` or `false`.
- A **flag** is a `bool` used to signal that something has happened, like a light switch: on = true, off = false.

## 6. Comparing Strings

You can compare two pieces of text (for example "Ali" and "Ali") to see whether they are the same.

## 7. `TryParse`

The user types text (like "25") and the program converts it to a number. If they type "abc", the program would crash.

`TryParse` attempts the conversion **safely** and returns `true` if it worked, `false` if not.

## 8. Input Validation

`TryParse` only checks that the input **is a number**. Validation checks that the number **makes sense**.

> Example: 999 hours in one week is a valid number, but not a realistic one.

## 9. RadioButton and CheckBox

| Control | What it does |
|---------|--------------|
| **RadioButton** | Pick **only one** option. Choosing one deselects the others |
| **CheckBox** | Pick **as many** options as you like |

- **`Checked`** tells you whether the control is selected.
- **`CheckedChanged`** is an event that fires when the selection changes.

## 10. The `switch` Statement

A cleaner alternative to `if-else-if` when **one variable** is compared against **many fixed values**.

> Example: day number (1 = Monday, 2 = Tuesday, ...).

`default` runs when nothing matches.

## 11. ListBox

A list of items from which the user can select one.

| Part | Meaning |
|------|---------|
| **Items** | The items in the list |
| **SelectedItem** | The chosen item |
| **SelectedIndex** | Its position (starts at **0**; **-1** if nothing is selected) |
| **Add** | Add an item |
| **Remove** | Remove a specific item |
| **RemoveAt** | Remove the item at a position |
| **Clear** | Remove everything |

## 12. Quick Summary

| I want to... | Use |
|--------------|-----|
| Do something only if a condition is true | `if` |
| Choose between two paths | `if-else` |
| Check several conditions in order | `if-else-if` |
| Check a condition inside another | Nested `if` |
| Combine conditions | AND, OR, NOT |
| Compare one variable to many fixed values | `switch` |
| Convert text to a number safely | `TryParse` |
| Let the user pick one option | RadioButton |
| Let the user pick many options | CheckBox |
| Show a list to choose from | ListBox |

## Reference

Gaddis, T. *Starting Out with Visual C#*, 6th Edition. Pearson Education.