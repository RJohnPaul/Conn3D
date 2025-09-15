"use client";

import { ChevronRightIcon } from "@heroicons/react/20/solid";

export default function Hero() {
  return (
    <div className="bg-white dark:bg-gray-900">
      <div className="relative isolate pt-20 bg-white dark:bg-gray-900">
        <svg
          aria-hidden="true"
          className="absolute inset-0 -z-10 size-full stroke-gray-200 dark:stroke-gray-800 [mask-image:radial-gradient(100%_100%_at_top_right,white,transparent)]"
        >
          <defs>
            <pattern
              x="50%"
              y={-1}
              id="83fd4e5a-9d52-42fc-97b6-718e5d7ee527"
              width={200}
              height={200}
              patternUnits="userSpaceOnUse"
            >
              <path d="M100 200V.5M.5 .5H200" fill="none" />
            </pattern>
          </defs>
          <svg
            x="50%"
            y={-1}
            className="overflow-visible fill-gray-50 dark:fill-gray-800"
          >
            <path
              d="M-100.5 0h201v201h-201Z M699.5 0h201v201h-201Z M499.5 400h201v201h-201Z M-300.5 600h201v201h-201Z"
              strokeWidth={0}
            />
          </svg>
          <rect
            fill="url(#83fd4e5a-9d52-42fc-97b6-718e5d7ee527)"
            width="100%"
            height="100%"
            strokeWidth={0}
          />
        </svg>
        <div className="mx-auto max-w-7xl px-6 py-24 sm:py-32 lg:flex lg:items-center lg:gap-x-10 lg:px-8 lg:py-40">
          <div className="mx-auto max-w-2xl lg:mx-0 lg:flex-auto">
            <div className="flex">
              <div className="relative flex items-center gap-x-4 rounded-full bg-white dark:bg-gray-800 px-4 py-1 text-sm/6 text-gray-600 dark:text-gray-300 ring-1 ring-gray-900/10 dark:ring-gray-700 hover:ring-gray-900/20 dark:hover:ring-gray-500">
                <span className="font-semibold text-indigo-600">
                  We’re doing this for 'HFH+CM'
                </span>
                <a href="#" className="flex items-center gap-x-1">
                  <ChevronRightIcon
                    aria-hidden="true"
                    className="-mr-2 size-5 text-gray-400 dark:text-gray-500"
                  />
                </a>
              </div>
            </div>
            <h1 className="mt-10 text-5xl font-semibold tracking-tight text-pretty text-gray-900 dark:text-gray-50 sm:text-7xl">
              A cooler way to visualize labs
            </h1>
            <p className="mt-8 text-lg font-medium text-pretty text-gray-500 dark:text-gray-300 sm:text-xl/8">
              Conn3D, we believe that technology should empower people — not
              slow them down. That’s why we built a smarter, faster, and more
              reliable way to bring your ideas to life. From concept to launch,
              our tools make it effortless to design, test, and deploy projects
              with confidence.
            </p>
            <div className="mt-10 flex items-center gap-x-6">
              <a
                href="/Hackathon-Build3.apk"
                download
                className="rounded-md bg-indigo-600 px-3.5 py-2.5 text-sm font-semibold text-white shadow-xs hover:bg-indigo-500 focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
              >
                Download Now
              </a>
              <a
                href="https://unity.com/"
                target="_blank"
                className="text-sm/6 font-semibold text-gray-900 dark:text-gray-100"
              >
                Learn more on unity <span aria-hidden="true">→</span>
              </a>
            </div>
          </div>
          <div className="mt-16 sm:mt-24 lg:mt-0 lg:shrink-0 lg:grow">
            <div className="mx-auto w-[22.875rem] max-w-full">
              <img
                src="/images/mobileprev.png"
                alt="Phone mockup showing app interface"
                className="w-full drop-shadow-xl"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
