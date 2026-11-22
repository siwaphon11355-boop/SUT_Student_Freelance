---
version: alpha
name: SUT Freelance Back Office (Evreghen Command Center Theme)
description: "Warm off-white security workspace with a dark frosted application shell and orange telemetry accents — ภาษาไทยเป็นหลัก (Thai Primary UI)"
language:
  primary: "th-TH"
  secondary: "en-US"
colors:
  background: "#fcfaf7"
  on-background: "#423d38"
  surface: "#f3f4f6"
  surface-soft: "#edebe9"
  surface-elevated: "#ffffff"
  on-surface: "#423d38"
  on-surface-muted: "#797067"
  outline: "#e3e0dd"
  outline-strong: "#d1d5dc"
  primary: "#fe6e00"
  primary-strong: "#ff6b00"
  primary-warm: "#ffb74d"
  primary-focus: "#f97015"
  on-primary: "#ffffff"
  shell-base: "#000000"
  on-shell: "#ffffff"
  shell-border: "#ffffff"
  success: "#00c758"
  warning: "#edb200"
  danger: "#fb2c36"
  info: "#3080ff"
  status-mock-bg: "#fef9c2"
  status-mock-fg: "#874b00"
  status-planned-bg: "#f3f4f6"
  status-planned-fg: "#364153"
  status-development-bg: "#dbeafe"
  status-development-fg: "#1447e6"
  status-integrated-bg: "#f3e8ff"
  status-integrated-fg: "#8200da"
  status-production-bg: "#dcfce7"
  status-production-fg: "#016630"
  dark-background: "#413830"
  dark-surface: "#4a423a"
  dark-on-surface: "#fafaf9"
  dark-on-surface-muted: "#b9b3ac"
typography:
  display-hero:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "6rem"
    fontWeight: 600
    lineHeight: 1
    letterSpacing: "-0.025em"
  headline-xl:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "2rem"
    fontWeight: 700
    lineHeight: "2.5rem"
    letterSpacing: "-0.025em"
  headline-lg:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "1.5rem"
    fontWeight: 700
    lineHeight: "2rem"
  title-md:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "1.125rem"
    fontWeight: 700
    lineHeight: "1.75rem"
  body-lg:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "1rem"
    fontWeight: 400
    lineHeight: "1.5rem"
  body-md:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "0.875rem"
    fontWeight: 400
    lineHeight: "1.25rem"
  body-sm:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "0.8125rem"
    fontWeight: 700
    lineHeight: "1rem"
  label-md:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "0.875rem"
    fontWeight: 500
    lineHeight: "1.25rem"
  label-sm:
    fontFamily: "ui-sans-serif, system-ui, -apple-system, 'Segoe UI', 'Noto Sans Thai', 'Sarabun', sans-serif"
    fontSize: "0.75rem"
    fontWeight: 600
    lineHeight: "1rem"
    letterSpacing: "0.05em"
  code-sm:
    fontFamily: "ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, monospace"
    fontSize: "0.875rem"
    fontWeight: 400
    lineHeight: "1.25rem"
rounded:
  xs: "4px"
  sm: "6px"
  md: "8px"
  lg: "12px"
  pill: "9999px"
spacing:
  xs: "4px"
  sm: "8px"
  md: "12px"
  lg: "16px"
  xl: "24px"
  "2xl": "32px"
  "3xl": "40px"
  "4xl": "64px"
  container-padding: "32px"
layout:
  container-max: "1400px"
  shell-header-height: "64px"
  shell-sidebar-expanded: "256px"
  shell-sidebar-collapsed: "64px"
motion:
  fast: "150ms"
  normal: "200ms"
  slow: "300ms"
  panel: "500ms"
  easing-standard: "cubic-bezier(0.4, 0, 0.2, 1)"
elevation:
  shell-blur: "12px"
  shell-opacity: "0.70"
  shell-border-opacity: "0.10"
  chart-fill-opacity: "0.60"
shadows:
  subtle: "0 1px 3px rgba(0, 0, 0, 0.10), 0 1px 2px rgba(0, 0, 0, 0.06)"
  raised: "0 4px 12px rgba(0, 0, 0, 0.12)"
  dialog: "0 20px 25px rgba(0, 0, 0, 0.10), 0 8px 10px rgba(0, 0, 0, 0.04)"
components:
  shell-sidebar:
    backgroundColor: "rgba(0, 0, 0, 0.70)"
    textColor: "{colors.on-shell}"
    rounded: "0px"
    width: "{layout.shell-sidebar-expanded}"
    padding: "{spacing.lg}"
  shell-header:
    backgroundColor: "rgba(0, 0, 0, 0.70)"
    textColor: "{colors.on-shell}"
    rounded: "0px"
    height: "{layout.shell-header-height}"
    padding: "0 16px"
  nav-item:
    backgroundColor: "transparent"
    textColor: "rgba(255, 255, 255, 0.70)"
    typography: "{typography.body-sm}"
    rounded: "{rounded.md}"
    padding: "6px 12px"
  nav-item-active:
    backgroundColor: "{colors.primary}"
    textColor: "{colors.on-primary}"
    typography: "{typography.body-sm}"
    rounded: "{rounded.md}"
    padding: "6px 12px"
  button-primary:
    backgroundColor: "{colors.primary}"
    textColor: "{colors.on-primary}"
    typography: "{typography.label-md}"
    rounded: "{rounded.sm}"
    height: "40px"
    padding: "0 16px"
  button-primary-hover:
    backgroundColor: "{colors.primary-strong}"
    textColor: "{colors.on-primary}"
  button-ghost-shell:
    backgroundColor: "transparent"
    textColor: "rgba(255, 255, 255, 0.70)"
    typography: "{typography.label-md}"
    rounded: "{rounded.md}"
    height: "40px"
    width: "40px"
  input-shell:
    backgroundColor: "rgba(255, 255, 255, 0.10)"
    textColor: "{colors.on-shell}"
    typography: "{typography.body-md}"
    rounded: "{rounded.sm}"
    height: "36px"
    padding: "0 12px"
  card-panel:
    backgroundColor: "{colors.surface-elevated}"
    textColor: "{colors.on-background}"
    typography: "{typography.body-md}"
    rounded: "{rounded.lg}"
    padding: "{spacing.xl}"
  chart-bar:
    backgroundColor: "rgba(254, 110, 0, 0.60)"
    textColor: "{colors.on-primary}"
    rounded: "{rounded.xs}"
  table-header:
    backgroundColor: "rgba(254, 110, 0, 0.05)"
    textColor: "{colors.primary-strong}"
    typography: "{typography.label-sm}"
    height: "48px"
    padding: "0 16px"
  table-cell:
    backgroundColor: "transparent"
    textColor: "{colors.on-surface-muted}"
    typography: "{typography.body-md}"
    padding: "8px 8px"
  status-badge-mock:
    backgroundColor: "{colors.status-mock-bg}"
    textColor: "{colors.status-mock-fg}"
    typography: "{typography.label-sm}"
    rounded: "{rounded.pill}"
    padding: "4px 10px"
  status-badge-planned:
    backgroundColor: "{colors.status-planned-bg}"
    textColor: "{colors.status-planned-fg}"
    typography: "{typography.label-sm}"
    rounded: "{rounded.pill}"
    padding: "4px 10px"
  status-badge-development:
    backgroundColor: "{colors.status-development-bg}"
    textColor: "{colors.status-development-fg}"
    typography: "{typography.label-sm}"
    rounded: "{rounded.pill}"
    padding: "4px 10px"
  status-badge-integrated:
    backgroundColor: "{colors.status-integrated-bg}"
    textColor: "{colors.status-integrated-fg}"
    typography: "{typography.label-sm}"
    rounded: "{rounded.pill}"
    padding: "4px 10px"
  status-badge-production:
    backgroundColor: "{colors.status-production-bg}"
    textColor: "{colors.status-production-fg}"
    typography: "{typography.label-sm}"
    rounded: "{rounded.pill}"
    padding: "4px 10px"
  login-panel:
    backgroundColor: "{colors.primary-strong}"
    textColor: "{colors.on-primary}"
    rounded: "0px"
    padding: "{spacing.2xl}"
  login-card:
    backgroundColor: "{colors.surface-elevated}"
    textColor: "{colors.on-surface}"
    rounded: "{rounded.md}"
    padding: "{spacing.2xl}"
---

# คู่มือแม่แบบดีไซน์และภาษา (Design & Localization Spec) — SUT Student Freelance Back Office

คุณสามารถแก้ไขค่าสี ฟอนต์ ขนาดความโค้งมน หรือข้อความในไฟล์ `design-spec.md` นี้ แล้วแจ้งให้ AI อัปเดตหน้าเว็บตามไฟล์นี้ได้ทันที

## 1. ภาพรวมสไตล์ (Evreghen Command Center)
- **พื้นหลังพื้นที่ทำงาน (Workspace Canvas):** สีขาวนวลอบอุ่น (`#FCFAF7`) สบายตา อ่านข้อมูลตารางได้นานไม่ล้าสายตา
- **กรอบแอปพลิเคชัน (Dark Frosted Application Shell):** แถบเมนูซ้าย (Sidebar) และแถบด้านบน (Top Header) ใช้พื้นหลังสีดำโปร่งแสง 70% (`rgba(0, 0, 0, 0.70)`) พร้อมเอฟเฟกต์เบลอกระจก (`backdrop-filter: blur(12px)`) ขอบสีขาวจางๆ และตัวอักษรสีขาว
- **สีเน้นหลัก (Primary Orange Accent):** สีส้มสด (`#FE6E00` / `#FF6B00`) สำหรับเมนูที่เลือกอยู่ (Active Nav), ปุ่มหลัก (Primary Button), กราฟข้อมูล (Telemetry/Charts), และจุดเน้นสำคัญ
- **ภาษาหลักของระบบ:** **ภาษาไทย (Thai Primary)** ครบทั้ง 15 หน้าจอ โดยคงข้อมูลและรายละเอียดเดิมของโครงการ SUT Student Freelance ไว้ครบถ้วน

## 2. โครงสร้างเมนูหลัก 15 หน้าจอ (ภาษาไทย)
1. **หน้าเข้าสู่ระบบจัดการหลังบ้าน** (`/`, `/login`)
2. **แดชบอร์ดภาพรวมการดำเนินงาน** (`/dashboard`)
3. **รายชื่อผู้ใช้งานนักศึกษาทั้งหมด** (`/users`)
4. **ข้อมูลโปรไฟล์นักศึกษา 360 องศา** (`/users/{Id}`)
5. **การลงโทษบัญชีและการควบคุมวินัยนักศึกษา** (`/users/sanctions`)
6. **รายชื่อผู้ให้บริการฟรีแลนซ์** (`/providers`)
7. **หน้าต่างตรวจสอบบัตรนักศึกษาและอนุมัติร้านค้า** (`/providers/verify/{StudentId}`)
8. **จัดการหมวดหมู่บริการ** (`/services/categories`)
9. **รายการบริการทั้งหมดในระบบ** (`/services`)
10. **ตรวจสอบรีวิวและความปลอดภัย** (`/moderation`)
11. **ตรวจสอบรูปภาพผลงานและพอร์ตโฟลิโอ** (`/moderation/content`)
12. **วิเคราะห์ความรู้สึก AI และตรวจสอบคุณภาพงาน** (`/analytics`)
13. **ศูนย์จัดการข้อพิพาทและรายงานความไม่เหมาะสม** (`/moderation/reports`)
14. **บันทึกการตรวจสอบระบบและความปลอดภัย (Audit Trail)** (`/audit`)
15. **การตั้งค่าระบบส่วนกลางและพารามิเตอร์นโยบาย** (`/settings`)
