# Conn3D (Connection-3D)

![Home Dashboard](https://github.com/RJohnPaul/Conn3D/blob/45e74934e32dbf64a9e1433391d5c0e569a835a8/starboy.png)

---

An immersive, mobile‑first Augmented Reality (AR) virtual electronics lab designed to bridge the gap between theoretical knowledge and practical engineering education.

<p align="center">
	<a href="https://nextjs.org"><img alt="Next.js" src="https://img.shields.io/badge/Next.js-15-black" /></a>
	<img alt="React" src="https://img.shields.io/badge/React-19-149eca" />
	<img alt="Tailwind" src="https://img.shields.io/badge/TailwindCSS-4-38bdf8" />
	<img alt="Status" src="https://img.shields.io/badge/Status-Alpha-orange" />
	<img alt="Node" src="https://img.shields.io/badge/Node-%3E=18.x-339933" />
	<img alt="License" src="https://img.shields.io/badge/License-TBD-lightgrey" />
	<img alt="PRs" src="https://img.shields.io/badge/PRs-Welcome-success" />
</p>

<p align="center"><i>Project status: Early content and architectural scaffold. Core AR & simulation layers implemented.</i></p>

---

## Table of Contents
1. [Overview](#1-overview)  
2. [Vision](#2-vision)  
3. [Core Principles](#3-core-principles)  
4. [Features](#4-features-current--in-progress)  
5. [Services Offered](#5-services-offered-concept-scope)  
6. [Technology Stack](#6-technology-stack)  
7. [Architecture & Structure](#7-architecture--structure)  
8. [UI Components](#8-ui-components-high-level-responsibilities)  
9. [Getting Started](#9-getting-started-local-development)  
10. [Available Scripts](#10-available-scripts)  
11. [Deployment](#11-deployment)  
12. [Roadmap](#12-roadmap-planned-enhancements)  
13. [Accessibility](#accessibility-checklist)  
14. [Performance Strategy](#performance-strategy)  
15. [Contribution Guide](#13-contributing)  
16. [FAQs](#14-faqs-sample)  
17. [License](#15-license)  
18. [Team](#team-nari-kootam)  
19. [Acknowledgements](#acknowledgements)  

---

## 1. Overview
Conn3D delivers a fully interactive virtual electronics laboratory accessible from any modern mobile device. It harnesses AR to let learners place and manipulate circuit components in real-world space, encouraging spatial reasoning, safe experimentation and intuitive understanding of hardware fundamentals.

## 2. Vision
To revolutionize technical education globally by providing every aspiring engineer with equitable access to a hands-on, high-fidelity electronics workspace—regardless of location or financial constraints.

## 3. Core Principles
- Interactive: Learning through tangible manipulation and immediate feedback.  
- Intuitive: Natural gestures and visual clarity reduce cognitive friction.  
- Accessible: Mobile-first experience lowers hardware and cost barriers.  

## 4. Features (Current / In Progress)
<table>
	<thead>
		<tr><th>Area</th><th>Description</th><th>Status</th><th>Next Step</th></tr>
	</thead>
	<tbody>
		<tr><td>Landing Narrative</td><td>Hero + structured educational sections</td><td>Implemented</td><td>Refine copy & accessibility review</td></tr>
		<tr><td>Component Architecture</td><td>Modular React components (App Router)</td><td>Implemented</td><td>Add test coverage</td></tr>
		<tr><td>Styling System</td><td>Tailwind CSS utility-first</td><td>Implemented</td><td>Establish design tokens</td></tr>
		<tr><td>AR Preview Layer</td><td>Placeholder conceptual content</td><td>Pending</td><td>Evaluate WebXR vs Native</td></tr>
		<tr><td>Simulation Engine</td><td>Real-time circuit feedback</td><td>Planned</td><td>Draft data model & solver</td></tr>
		<tr><td>Cloud Persistence</td><td>Profiles, saved circuits</td><td>Planned</td><td>Define schema</td></tr>
	</tbody>
</table>

## 5. Services Offered (Concept Scope)
| Service | Description |
|---------|-------------|
| Mobile AR App | Transforms any flat surface into an interactive electronics bench. |
| Real-Time Simulation | Immediate circuit feedback via a custom simulation layer (planned). |
| Virtual Component Library | Expanding catalog of 3D electronic parts. |
| Safe Workspace | Risk-free experimentation without physical damage or hazards. |

## 6. Technology Stack
| Layer | Choice | Rationale |
|-------|--------|-----------|
| Framework | Next.js 15 (App Router) | File-based routing, streaming, server components |
| Runtime | React 19 | Concurrent features, future-proof for interactive AR panels |
| Styling | Tailwind CSS 4 | Rapid iteration, consistent spacing/typography scale |
| UI Elements | Headless UI, Heroicons | Accessible primitives without opinionated styling |
| Fonts | Geist (next/font) | Automatic optimization & variable font control |
| Planned AR | ARCore / ARKit / WebXR bridge | Device-native tracking & portability |
| Simulation Engine | Custom lightweight solver | Fine-grained control over performance & accuracy |
| Backend (Future) | Firebase / AWS | Realtime sync, auth, scalable storage |
| Analytics (Future) | PostHog / Plausible | Privacy-friendly usage insights |

## 7. Architecture & Structure
```
src/
	app/
		layout.js        # Root layout, font setup, metadata
		page.js          # Landing page composition
		hero.jsx         # Conn3D overview & sectional narrative
		feature.jsx      # Highlighted feature blocks
		cta.jsx          # Call-to-action section
		banner.jsx       # Top banner (announcements / messaging)
		navbar.jsx       # Navigation shell (future expansion)
		stats.jsx        # Placeholder for metrics / impact highlights
		team.jsx         # Team introduction
		faq.jsx          # Frequently asked questions section
		footer.jsx       # Footer / links
		globals.css      # Tailwind base + project-level styles
```
Separation of concerns: each semantic content block lives in an isolated component, enabling future progressive enhancement (e.g., hydration boundaries, streamed sections, dynamic AR previews, or lazy-loaded simulation widgets).

## 8. UI Components (High-Level Responsibilities)
- `Hero`: Narrative core (About, Vision, Services, Technology, Impact, Outlook).  
- `Feature`: Space for showcasing differentiated capabilities.  
- `CTA`: Drives user engagement (signup / waitlist / demo scheduling).  
- `Faq`: Structured Q&A to reduce friction.  
- `Team`: Human credibility layer.  
- `Stats`: Designed for future adoption metrics, learning outcomes or performance indicators.  

## 9. Getting Started (Local Development)
Prerequisites:
- Node.js 18+ (verify with `node -v`)
- Git
- A package manager (npm included by default)

Clone & install:
```bash
git clone https://github.com/RJohnPaul/Conn3D.git .
npm install
```

Development server:
```bash
npm run dev
```
Visit: http://localhost:3000

Production build preview:
```bash
npm run build
npm start
```

### Directory Conventions
- Use the `app/` directory for route-based composition (Next.js App Router).  
- Co-locate component-level styles or keep to utility-first Tailwind classes.
- Go to the `AR Assets` folder to gain intel on the AR Codebase

## 10. Available Scripts
| Script | Purpose |
|--------|---------|
| `npm run dev` | Start local development server with hot reload. |
| `npm run build` | Create an optimized production build. |
| `npm run start` | Run the production build locally. |

## 11. Deployment
Recommended: Vercel (first-class support for Next.js).  
Basic flow:
1. Push to main or open a pull request.  
2. Vercel detects framework and builds automatically.  
3. Inspect preview deployment.  
4. Merge to production branch for live release.  

Environment variables (future): simulation backends, feature flags, analytics keys. None currently required.

## 12. Roadmap (Planned Enhancements)
| Phase | Milestones | Deliverables | Exit Criteria |
|-------|-----------|--------------|---------------|
| 1 | Foundation | Accessible landing, component audit, metrics baseline | CLS < 0.1, Lighthouse A11y > 95 |
| 2 | AR Prototype | Basic placement of 3D components (stub interactions) | Stable 30+ FPS on mid-tier device |
| 3 | Simulation MVP | Ohmic + reactive elements, live value overlays | < 10ms step calc for small circuits |
| 4 | Persistence & Collab | Auth, save/load, share links | Multi-user edit latency < 300ms |
| 5 | Intelligent Tutor | Contextual hints, adaptive challenges | 75%+ task success in user tests |
| 6 | Advanced Components | MCUs, sensors, renewable modules | Verified component test suite |

### AR & Simulation Conceptual Layers
1. Scene Management (entity/component registry)  
2. Tracking & Spatial Anchors (ARCore/ARKit abstraction)  
3. Physics/Electrical Solver (incremental time steps)  
4. Interaction Layer (gesture → semantic intent)  
5. Visualization (probes, overlays, waveform inspectors)  
6. Persistence Sync (CRDT or operational transforms)  

### Data Model Draft (Planned)
```ts
Circuit {
	id: string;
	components: ComponentInstance[]; // typed refs
	nets: Net[];                     // connectivity graph
	metadata: { title?: string; version: number; createdAt: ISODate };
}
```

> This model will evolve once simulation constraints and collaborative editing semantics are formalized.

## Accessibility Checklist
| Area | Status | Notes |
|------|--------|-------|
| Semantic Headings | In Progress | Ensure single H1, descending order |
| Color Contrast | Pending Review | Add token palette & test contrasts |
| Focus States | Basic | Need visible outline normalization |
| Aria Labels | Pending | Add to interactive navigation elements |
| Reduced Motion | Not Implemented | Add prefers-reduced-motion handling |

## Performance Strategy
| Layer | Intent |
|-------|--------|
| Code Splitting | Use dynamic import for heavy AR bundles |
| Streaming | Leverage React Server Components where static narrative suffices |
| Asset Policy | Prefer responsive images / vector icons (no raster for simple shapes) |
| CSS | Tailwind JIT purging for minimal bundle |
| Simulation | Web Worker / WASM exploration for isolation |
| Caching | HTTP caching for static assets; future SW for offline library |

Planned metrics: First Contentful Paint, Time to Interactive, Simulation Step Latency.

## 13. Contributing
Contributions are welcome.

Workflow:
1. Fork repository  
2. Branch naming: `feat/`, `fix/`, `chore/`, `docs/`  
3. Commit convention (Conventional Commits): `feat(hero): add AR roadmap section`  
4. Ensure build succeeds: `npm run build`  
5. Open PR with: context, before/after (screenshots if UI), test notes  

Coding Guidelines:
- Keep components cohesive; extract only after 2–3 repetitions.  
- Prefer composition over inheritance.  
- Enforce accessible markup (run automated Lighthouse / axe).  
- Avoid global state until justified; lean on props & server components.  
- Document non-trivial decisions in a short `DECISIONS.md` (future).  

Security & Privacy (Future Phases):
- Principle of least privilege for backend services.  
- Input validation on circuit definitions.  
- Opt-in analytics with anonymization.  

## 14. FAQs (Sample)
| Question | Answer |
|----------|--------|
| Will a native mobile version exist? | Planned—initial AR experiments will determine delivery path (WebXR vs native wrapper). |
| How are circuits simulated? | A custom lightweight engine (in design) will model basic electrical behavior with real-time feedback. |
| Will advanced components (MCUs, sensors) be included? | Yes—phase expansion includes microcontrollers, renewable energy modules and more. |
| Is offline use supported? | Intended in future builds with local caching for component libraries. |

## Team
Agilesh Arumugam • Madhesh H • Karan S • John Paul R

---

For questions or collaboration inquiries, open an issue or start a discussion thread.
# Conn3D
# Conn3D-EEE
