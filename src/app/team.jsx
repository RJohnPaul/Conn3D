const people = [
  {
    name: 'Agilesh',
    role: 'Unity Lead Developer',
    imageUrl:
      'https://media.licdn.com/dms/image/v2/D5603AQFQJuOL6nWG6g/profile-displayphoto-shrink_400_400/B56ZU3XD4wHQAk-/0/1740390550540?e=1759968000&v=beta&t=oZRc1vy6GvCzxb4wtNzcLq-0wvvH5tqMtfAiT5w3WII',
    bio: 'Implemented the entire Unity codebase: core architecture, gameplay systems, optimization, and build pipeline.',
  },
  {
    name: 'John Paul',
    role: 'Full‑Stack & Platform Integrations',
    imageUrl: '/images/john.jpeg',
    bio: 'Built the landing page and handled site ↔ Unity integration plus application connectivity and deployment setup.',
  },
  {
    name: 'Karan',
    role: 'Frontend & Components Developer',
    imageUrl: '/images/karan.jpeg',
    bio: 'Developed interactive UI components (e.g. bulbs) and presentation layer elements used across the app.',
  },
  {
    name: 'Madhesh',
    role: 'Prefab & Assets Engineer',
    imageUrl: 'https://madhesh.vercel.app/assets/img/profile.jpg',
    bio: 'Prepared and organized prefabs for all components, ensuring clean reusable 3D asset structure and consistency.',
  },
]

export default function Team() {
  return (
    <div className="bg-gray-900 py-24 sm:py-32">
      <div className="mx-auto max-w-7xl px-6 lg:px-8">
        <div className="mx-auto max-w-2xl sm:text-center">
          <h2 className="text-34l font-semibold tracking-tight text-balance text-gray-300 sm:text-5xl">
            Meet our leadership
          </h2>
          <p className="mt-6 text-lg/8 text-gray-400">
            We’re a dynamic group of individuals who are passionate about what we do and dedicated to delivering the
            best results for our clients.
          </p>
        </div>
        <ul
          role="list"
          className="mx-auto mt-20 grid max-w-2xl grid-cols-1 gap-x-6 gap-y-20 sm:grid-cols-2 lg:max-w-4xl lg:gap-x-8 xl:max-w-none"
        >
          {people.map((person) => (
            <li key={person.name} className="flex flex-col gap-6 xl:flex-row">
              <img alt="" src={person.imageUrl} className="aspect-4/5 w-52 flex-none rounded-2xl object-cover" />
              <div className="flex-auto">
                <h3 className="text-lg/8 font-semibold tracking-tight text-gray-900">{person.name}</h3>
                <p className="text-base/7 text-gray-300">{person.role}</p>
                <p className="mt-6 text-base/7 text-gray-300">{person.bio}</p>
              </div>
            </li>
          ))}
        </ul>
      </div>
    </div>
  )
}
