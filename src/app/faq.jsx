import { Disclosure, DisclosureButton, DisclosurePanel } from '@headlessui/react'
import { MinusSmallIcon, PlusSmallIcon } from '@heroicons/react/24/outline'
// hi
const faqs = [
  {
    question: "What is Conn3D?",
    answer:
      "Conn3D is an Augmented Reality–powered virtual lab that lets students and creators design, simulate, and visualize circuits in a fully interactive 3D space — anytime, anywhere.",
  },
  {
    question: "Do I need special hardware to use Conn3D?",
    answer:
      "Nope! Conn3D runs on regular smartphones and tablets (iOS & Android) using ARKit and ARCore. No costly lab equipment required.",
  },
  {
    question: "Can Conn3D replace a physical electronics lab?",
    answer:
      "While Conn3D is designed to supplement hands-on labs, it offers a safe, affordable, and accessible alternative for learning and experimenting — especially where real labs are limited or unavailable.",
  },
  {
    question: "What kind of components are available?",
    answer:
      "Our virtual library includes basics like resistors, LEDs, and capacitors, all the way up to advanced modules like ICs, microcontrollers (Arduino, Raspberry Pi), and renewable energy systems.",
  },
  {
    question: "Is it safe for beginners?",
    answer:
      "Absolutely. Since everything is virtual, there’s zero risk of electric shock or hardware damage. It’s the perfect way to learn by doing.",
  },
  {
    question: "Can I collaborate with others in Conn3D?",
    answer:
      "Yes! Future updates will include cloud-based saving and real-time collaboration, so multiple users can work together on the same project.",
  },
  {
    question: "Is Conn3D free to use?",
    answer:
      "We offer a free version with essential features, plus premium plans for advanced components, AI tutoring, and collaborative tools.",
  },
]

export default function Faq() {
  return (
    <div className="bg-gray-900">
      <div className="mx-auto max-w-7xl px-6 py-24 sm:py-32 lg:px-8 lg:py-40">
        <div className="mx-auto max-w-4xl">
          <h2 className="text-4xl font-semibold tracking-tight text-white sm:text-5xl">Frequently asked questions</h2>
          <dl className="mt-16 divide-y divide-white/10">
            {faqs.map((faq) => (
              <Disclosure key={faq.question} as="div" className="py-6 first:pt-0 last:pb-0">
                <dt>
                  <DisclosureButton className="group flex w-full items-start justify-between text-left text-white">
                    <span className="text-base/7 font-semibold">{faq.question}</span>
                    <span className="ml-6 flex h-7 items-center">
                      <PlusSmallIcon aria-hidden="true" className="size-6 group-data-open:hidden" />
                      <MinusSmallIcon aria-hidden="true" className="size-6 group-not-data-open:hidden" />
                    </span>
                  </DisclosureButton>
                </dt>
                <DisclosurePanel as="dd" className="mt-2 pr-12">
                  <p className="text-base/7 text-gray-300">{faq.answer}</p>
                </DisclosurePanel>
              </Disclosure>
            ))}
          </dl>
        </div>
      </div>
    </div>
  )
}
