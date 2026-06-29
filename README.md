# DeathSwitch 🛡️

> *What if your bank could protect your family before the paperwork caught up?*

**3rd Place — Standard Bank: Beat the Banker & BBD Hackathon 2026**

---

## The Idea

In South Africa, families wait months to access a deceased person's 
bank account. DeathSwitch flips that. It monitors real signals, 
verifies death probability, and releases funds to verified 
beneficiaries — in hours, not months.

Built in 24 hours. Demoed to Standard Bank and BBD judges.

---

## What We Built

A fully interactive prototype with two views:

**Account Holder View**
- Dashboard showing DeathSwitch status and liveness ping
- Add and manage beneficiaries with percentage allocations
- Biometric identity verification flow (ID → Face scan → Fingerprint)

**Beneficiary View**
- Real-time death probability engine (0% → 100%)
- Five-signal release system:

| Signal | Weight |
|--------|--------|
| Hospital discharge code | 40/40 |
| BI-1663 portal | 30/30 |
| Next of kin report | 15/15 |
| Liveness ping | 10/10 |
| Network presence | 5/5 |

- Verified beneficiary allocation view
- Emergency fund release triggered at 70% probability
- Full distribution at 85%

---

## Fraud Prevention

- Biometric verification required to add any beneficiary
- Staged release — emergency funds first, full distribution later
- Multi-signal consensus before any action is taken
- All beneficiaries verified independently before release

---

## Screenshots

> *Account holder dashboard, beneficiary management,*
> *identity verification flow, and beneficiary signal view*

<!-- Add screenshots here -->
<img width="1023" height="752" alt="Screenshot 2026-06-30 000528" src="https://github.com/user-attachments/assets/a56d8754-d6a9-47a2-a984-6e7d7f69fcb8" />
<img width="394" height="508" alt="Screenshot 2026-06-30 000434" src="https://github.com/user-attachments/assets/5fbcaa91-4922-4010-ad23-8ada21e058f7" />
<img width="405" height="826" alt="Screenshot 2026-06-30 000409" src="https://github.com/user-attachments/assets/17d81dce-1de2-40b0-8cd0-100a0f3dffeb" />
<img width="472" height="819" alt="Screenshot 2026-06-30 000329" src="https://github.com/user-attachments/assets/95d6a54b-f0d4-4062-ad6b-7c6f4ab9335f" />

---

## Stack

HTML · CSS · JavaScript  
Prototype only — no live banking API connections

---

## Status

> Concept and prototype stage.  
> Developed during a 24-hour hackathon.  
> Earmarked for future development.

---

## Built By

Ofentse Ngcongca & team  
Standard Bank & BBD Hackathon — 2025 · 🥉 3rd Place
