import React from 'react';

import cx from 'classnames';

import { HeroResponse } from '../api';
import HeroImage from './HeroImage';

type TeamHeroListHeroProps = {
  hero: HeroResponse;
  onRemove: (hero: HeroResponse) => void;
};

const TeamHeroListHero: React.FC<TeamHeroListHeroProps> = (props: TeamHeroListHeroProps) => {
  return (
    <HeroImage hero={props.hero} className='flex-shrink-0 flex-grow-0'>
      <div
        className='bg-red-400 opacity-0 hover:opacity-50 h-full w-full cursor-pointer'
        onClick={() => props.onRemove(props.hero)}
      ></div>
    </HeroImage>
  );
};

export default TeamHeroListHero;
